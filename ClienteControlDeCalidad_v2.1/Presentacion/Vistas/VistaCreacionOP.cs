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
    public partial class VistaCreacionOP : Form, IVistaCreacionOP
    {
        private IPresentadorCreacionOP _presentador;
        public VistaCreacionOP(IPresentadorCreacionOP presentador)
        {
            InitializeComponent();
            _presentador = presentador;
            _presentador.EstablecerVista(this);
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

        private void colorBTN_Click(object sender, EventArgs e)
        {
            string seleccion = _presentador.SeleccionarColor();
            if (seleccion != string.Empty)
            {
                colorSeleccionadoLB.Text = seleccion;
            }
        }

        private void modeloBTN_Click(object sender, EventArgs e)
        {
            string seleccion = _presentador.SeleccionarModelo();
            if(seleccion != string.Empty)
            {
                modeloSeleccionadoLB.Text = seleccion;
            }
        }

        private void lineasBTN_Click(object sender, EventArgs e)
        {
            string seleccion = _presentador.SeleccionarLinea();
            if (seleccion != string.Empty)
            {
                lineaSeleccionadaLB.Text = seleccion;
            }
        }

        private void numeroOpAsignadoTB_TextChanged(object sender, EventArgs e)
        {
            VerificadorDeEntradas.Instance.SoloNumeros(numeroOpAsignadoTB);
        }

        private void limpiarEntradasBTN_Click(object sender, EventArgs e)
        {
            modeloSeleccionadoLB.Text = "Modelo";
            lineaSeleccionadaLB.Text = "Linea";
            colorSeleccionadoLB.Text = "Color";
            numeroOpAsignadoTB.Text = "000000";
            _presentador.LimpiarEntradas();
        }



        private void confirmarCreacionBTN_Click(object sender, EventArgs e)
        {
            _presentador.InsertarOp(numeroOpAsignadoTB.Text);
        }
    }
}
