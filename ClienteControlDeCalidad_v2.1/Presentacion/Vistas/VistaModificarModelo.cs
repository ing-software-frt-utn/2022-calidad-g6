using ConexionWeb.ConexionWebService;
using Presentacion.IPresentadores;
using Presentacion.IVistas;
using Presentación.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transversal;

namespace Presentacion.Vistas
{
    public partial class VistaModificarModelo : Form, IVistaModificarModelo
    {
        private bool _modeloSeleccionado = false;
        private bool _modificacionesEnCampos = false;
        private bool _camposCorrectosParaGuardar = false;
        private int _filaSeleccionada = -99;
        private IPresentadorGestionarModelos _presentador;
        private IVerificadorDeEntradas _verificadorDeEntradas = VerificadorDeEntradas.Instance;

        public VistaModificarModelo(IPresentadorGestionarModelos presentador)
        {
            InitializeComponent();
            _presentador = presentador;
            _presentador.EstablecerReferenciaVistaModificar(this);
        }

        private void VistaModificarModelo_Load(object sender, EventArgs e)
        {
            CargarTablaModelos(_presentador.ObtenerModelos());
        }


        #region Interacciones con el datagrid de modelos
        public void CargarTablaModelos(List<ModeloDTO> modelos) // En este método se cargan los datos de cada modelo en cada una de las filas de la tabla.
        {
            listadoModelosDG.Rows.Clear();

            foreach (var item in modelos)
            {
                listadoModelosDG.Rows.Add(item.ModeloId, item.Descripcion, item.SKU, item.LimiteInferiorReproceso, item.LimiteInferiorObservado, item.LimiteSuperiorReproceso, item.LimiteSuperiorObservado);
            }
        }
        public void SeleccionarModelo()
        {
            LimpiarDatosSeleccionados();
            visualizarSkuLB.Text = listadoModelosDG.Rows[_filaSeleccionada].Cells[2].Value.ToString();
            visualizarDenominacionTB.Text = listadoModelosDG.Rows[_filaSeleccionada].Cells[1].Value.ToString();

            limiteInferiorReprocesoTB.Text = listadoModelosDG.Rows[_filaSeleccionada].Cells[3].Value.ToString();
            limiteInferiorObservadoTB.Text = listadoModelosDG.Rows[_filaSeleccionada].Cells[4].Value.ToString();
            limiteSuperiorReprocesoTB.Text = listadoModelosDG.Rows[_filaSeleccionada].Cells[5].Value.ToString();
            limiteSuperiorObservadoTB.Text = listadoModelosDG.Rows[_filaSeleccionada].Cells[6].Value.ToString();

            _presentador.SetearValoresInicialesModeloSeleccionado(visualizarDenominacionTB.Text, limiteInferiorReprocesoTB.Text, limiteInferiorObservadoTB.Text, limiteSuperiorReprocesoTB.Text, limiteSuperiorObservadoTB.Text);

            _modeloSeleccionado = true;
        }
        #endregion
        private void guardarModificacionesBTN_Click(object sender, EventArgs e) // Guardar cambios en un modelo
        {
            _camposCorrectosParaGuardar = _presentador.ComprobacionGeneralParaGuardarCambiosEnModelo(visualizarDenominacionTB.Text, limiteInferiorReprocesoTB.Text, limiteInferiorObservadoTB.Text, limiteSuperiorReprocesoTB.Text, limiteSuperiorObservadoTB.Text);
            if (_camposCorrectosParaGuardar) // Antes compruebo que efectivamente hayan habido cambios en los campos del modelo
            {

                int id = int.Parse(listadoModelosDG.SelectedRows[0].Cells[0].Value.ToString()); // SelectedRows[0], el 0 corresponde a una cuestión del lenguaje, para seleccionar el elemento clickeado.
                                                                               // Cells[0] elijo la primera celda de la fila seleeccionada: Id de modelo (de la DB).

                _presentador.GuardarModificacionModelo(id, visualizarDenominacionTB.Text, limiteInferiorReprocesoTB.Text, limiteInferiorObservadoTB.Text, limiteSuperiorReprocesoTB.Text, limiteSuperiorObservadoTB.Text);
            }
            else
            {
                MostrarMensaje("Operacion Invalida","No se pude modifiar el modelo.\nCompruebe que los datos:\nHayan sido modificados\nNo son nulos\nQue los límites inferiores son menores a los superiores.",false,null,Color.FromArgb(233,141,3));
            }
        }
        private void listadoModelosDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != _filaSeleccionada)
            {
                if (e.RowIndex >= 0)
                {
                    _modificacionesEnCampos = _presentador.ComprobarExistenciaDeModificacionesEnCampos(visualizarDenominacionTB.Text, limiteInferiorReprocesoTB.Text, limiteInferiorObservadoTB.Text, limiteSuperiorReprocesoTB.Text, limiteSuperiorObservadoTB.Text);
                    //Aquí cambiar el modelo seleccionado, en consecuencia cambian sus datos, los de los textbox y el label.
                    if (_modeloSeleccionado && _modificacionesEnCampos) // Acá debería poner el caso en el que no estaba  modificando ningún modelo aún, la primera vez.
                                                                        // (Corrección) creo que acá va el caso en el que ya hubieron modificaciones.
                    {
                        DialogResult resultado = new VistaMensaje("Advertencia", "Perdera los cambios realizados.\n ¿Desea continuar?", true, null, Color.FromArgb(139, 0, 0)).ShowDialog();
                        if (resultado == DialogResult.OK)
                        {
                            _filaSeleccionada = e.RowIndex;
                            SeleccionarModelo();
                        }
                        else
                        {
                            listadoModelosDG.ClearSelection();
                            listadoModelosDG.Rows[_filaSeleccionada].Selected = true;
                        }
                    }
                    else // este es el caso en el que es la primera vez que selecciono un modelo.
                    {
                        _filaSeleccionada = e.RowIndex;
                        SeleccionarModelo();
                    }
                }
            }
        }
        public void LimpiarSeleccion()
        {
            visualizarSkuLB.Text = "";
            visualizarDenominacionTB.Text = "";
            limiteInferiorReprocesoTB.Text = "";
            limiteInferiorObservadoTB.Text = "";
            limiteSuperiorReprocesoTB.Text = "";
            limiteSuperiorObservadoTB.Text = "";
            listadoModelosDG.ClearSelection();
            CargarTablaModelos(_presentador.ObtenerModelos());
            listadoModelosDG.Rows[0].Selected = false;
            _filaSeleccionada = -99;
            _modeloSeleccionado = false;
        }

        private void LimpiarDatosSeleccionados()
        {
            visualizarSkuLB.Text = "";
            visualizarDenominacionTB.Text = "";
            limiteInferiorReprocesoTB.Text = "";
            limiteInferiorObservadoTB.Text = "";
            limiteSuperiorReprocesoTB.Text = "";
            limiteSuperiorObservadoTB.Text = "";
        }


        #region Metodos Mostrar mensaje
        public bool MostrarMensaje(string title, string messageInfo, bool cancelOption)
        {
            bool respuesta = false;
            DialogResult result = new VistaMensaje(title, messageInfo, cancelOption).ShowDialog();

            if (result == DialogResult.OK)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public bool MostrarMensaje(string title, string messageInfo, bool cancelOption, Image icon, Color wantedColor)
        {
            bool respuesta = false;
            DialogResult result = new VistaMensaje(title, messageInfo, cancelOption, icon, wantedColor).ShowDialog();
            if (result == DialogResult.OK)
            {
                respuesta = true;
            }
            return respuesta;
        }
        #endregion

        #region Métodos que comprueban que los campos de límites tengan de entrada solamente números
        private void limiteInferiorReprocesoTB_TextChanged(object sender, EventArgs e)
        {
            _verificadorDeEntradas.SoloNumeros(limiteInferiorReprocesoTB);
        }

        private void limiteSuperiorReprocesoLBTB_TextChanged(object sender, EventArgs e)
        {
            _verificadorDeEntradas.SoloNumeros(limiteSuperiorReprocesoTB);
        }

        private void limiteInferiorObservadoTB_TextChanged(object sender, EventArgs e)
        {
            _verificadorDeEntradas.SoloNumeros(limiteInferiorObservadoTB);
        }

        private void limiteSuperiorObservadoTV_TextChanged(object sender, EventArgs e)
        {
            _verificadorDeEntradas.SoloNumeros(limiteSuperiorObservadoTB);
        }
        #endregion

        #region Métodos para filtrar modelos en el datagrid
        private void buscarModelosTB_TextChanged(object sender, EventArgs e)
        {
           CargarTablaModelos(_presentador.BuscarModelos(buscarModelosTB.Text));
        }
        private void buscarPorSKURB_CheckedChanged(object sender, EventArgs e)
        {
            if (buscarPorSKURB.Checked) _presentador.SetearMetodoDeBusqueda(false);
        }

        private void buscarPorDescripcionRB_CheckedChanged(object sender, EventArgs e)
        {
            if (buscarPorDescripcionRB.Checked) _presentador.SetearMetodoDeBusqueda(true);
        }


        #endregion


    }
}
