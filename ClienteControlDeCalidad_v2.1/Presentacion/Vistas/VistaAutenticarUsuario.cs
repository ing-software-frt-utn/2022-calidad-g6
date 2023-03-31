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

namespace Presentacion.Vistas
{
    public partial class VistaAutenticarUsuario : Form, IVistaAutenticarUsuario
    {
        private IPresentadorAutenticarUsuario _presentador;
        public VistaAutenticarUsuario(IVistaContenedor vistaContenedor)
        {
            InitializeComponent();

            _presentador = PresentadorAutenticarUsuario.Instance;
            _presentador.EstablecerVistas(this, vistaContenedor);

        }

        private void iniciarSesionBTN_Click(object sender, EventArgs e)
        {
            _presentador.LogearUsuario(usuarioTB.Text,contrasenaTB.Text);
        }
        #region Metodos Mostrar mensaje
        public bool MostrarMensaje(string title, string messageInfo, bool cancelOption)
        {
            bool respuesta = false;
            DialogResult result = new VistaMensaje(title, messageInfo, cancelOption).ShowDialog();

            if(result == DialogResult.OK)
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
        private void auInicioSesionPN_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}