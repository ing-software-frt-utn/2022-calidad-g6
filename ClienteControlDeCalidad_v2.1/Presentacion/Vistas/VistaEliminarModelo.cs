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

namespace Presentacion.Vistas
{
    public partial class VistaEliminarModelo : Form, IVistaEliminarModelo
    {
        private int _filaSeleccionada = -99;
        private IPresentadorGestionarModelos _presentador;

        public VistaEliminarModelo(IPresentadorGestionarModelos presentador)
        {
            InitializeComponent();
            _presentador = presentador;
            _presentador.EstablecerReferenciaVistaEliminar(this);
            CargarTablaModelos(_presentador.ObtenerModelos());

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


        #region Métodos relacionados al datagrid de modelos
        public void CargarTablaModelos(List<ModeloDTO> modelos) // En este método se cargan los datos de cada modelo en cada una de las filas de la tabla.
        {
            listadoModelosDG.Rows.Clear();

            foreach (var item in modelos)
            {
                listadoModelosDG.Rows.Add(item.ModeloId, item.Descripcion, item.SKU, item.LimiteInferiorReproceso, item.LimiteInferiorObservado, item.LimiteSuperiorReproceso, item.LimiteSuperiorObservado);
            }

        }

        #endregion


        private void eliminarModeloBTN_Click(object sender, EventArgs e)
        {
            if (MostrarMensaje("Confirmar Acción", "Va a eliminar el modelo seleccionado. \n Desea continuar?", true, null, Color.FromArgb(10, 10, 90)))
            {
                _presentador.EliminarModelo(int.Parse(listadoModelosDG.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }

        private void buscarModelosTB_TextChanged(object sender, EventArgs e)
        {
            CargarTablaModelos( _presentador.BuscarModelos(buscarModelosTB.Text));
        }

        private void buscarPorSKURB_CheckedChanged(object sender, EventArgs e)
        {
            
            if (buscarPorSKURB.Checked) _presentador.SetearMetodoDeBusqueda(false);
        }

        private void buscarPorDescripcionRB_CheckedChanged(object sender, EventArgs e)
        {
            if (buscarPorDescripcionRB.Checked) _presentador.SetearMetodoDeBusqueda(true);
        }

        public void ActualizarTabla()
        {
            CargarTablaModelos(_presentador.ObtenerModelos());
            _filaSeleccionada = -99;
        }
    }
}
