using ConexionWeb.ConexionWebService;
using Presentacion.IPresentadores;
using Presentacion.IVistas;
using Presentacion.Presentadores;
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
    public partial class VistaNuevoModelo : Form, IVistaNuevoModelo
    {
        private IPresentadorGestionarModelos _presentador;
        private IVerificadorDeEntradas _verificador = VerificadorDeEntradas.Instance;

        public VistaNuevoModelo(IPresentadorGestionarModelos presentador)
        {
            InitializeComponent();
            _presentador = presentador;
            _presentador.EstablecerReferenciaVistaNuevo(this);
        }

        private void VistaNuevoModelo_Load(object sender, EventArgs e)
        {
          //  CargarTablaColores(_presentador.ObtenerModelos());
        }

        private void limpiarEntradasBTN_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
            /*skuTB.Text = "";
            denominacionTB.Text = "";
            limiteInfReproTB.Text = "";
            limiteSupReproTB.Text = "";
            limiteInfObsTB.Text = "";
            limiteSupObsTB.Text = "";*/
        }

        private void limpiarEntradas()
        {
            skuTB.Text = "";
            denominacionTB.Text = "";
            limiteInfReproTB.Text = "";
            limiteSupReproTB.Text = "";
            limiteInfObsTB.Text = "";
            limiteSupObsTB.Text = "";
        }
        private void confirmarModeloBTN_Click(object sender, EventArgs e)
        {
            bool existeCampoVacio = _presentador.ComprobarSiAlgunCampoEstaVacio(skuTB.Text, denominacionTB.Text, limiteInfReproTB.Text, limiteInfObsTB.Text, limiteSupReproTB.Text, limiteSupObsTB.Text);
            if (!existeCampoVacio)
            {
                bool respuesta = MostrarMensaje("Confirmar Acción","Se registrara un nuevo modelo\nen la base de datos.\nDesea continuar?",true,null,Color.FromArgb(10,10,90));
                if (respuesta)
                {
                    _presentador.CrearNuevoModelo(skuTB.Text, denominacionTB.Text, int.Parse(limiteInfReproTB.Text), int.Parse(limiteSupReproTB.Text), int.Parse(limiteInfObsTB.Text), int.Parse(limiteSupObsTB.Text));
                    limpiarEntradas();
                }
                                
            }
            else
            {
                MostrarMensaje("Campo sin completar", "Al menos un campo está vacío", false, null, Color.Red);
            }
        }

        private void limiteInfReproTB_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros(limiteInfReproTB);
        }

        private void limiteSupReproTB_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros(limiteSupReproTB);
        }

        private void limiteInfObsTB_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros(limiteInfObsTB);
        }

        private void limiteSupObsTB_TextChanged(object sender, EventArgs e)
        {
            SoloNumeros(limiteSupObsTB);
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

        private void SoloNumeros(TextBox sender)
        {
            _verificador.SoloNumeros(sender);
        }

    }
}
