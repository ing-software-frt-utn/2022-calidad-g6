using Presentacion.IPresentadores;
using Presentacion.IVistas;
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
    public partial class VistaGestionarModelos : Form, IVistaGestionarModelos
    {
        private int _idVentanaActiva = -1;
        private Form _ventanaActiva;
        private IPresentadorGestionarModelos _presentador;
        public VistaGestionarModelos(IPresentadorGestionarModelos presentador)
        {
            InitializeComponent();
            _presentador = presentador;
        }

        private void VistaGestionarModelos_Load(object sender, EventArgs e)
        {
            nuevoModeloBTN_Click(null,null);
        }

        private void AbrirVentana(Form ventana)
        {
            if (_ventanaActiva != null)
            {
                _ventanaActiva.Close();
            }

            _ventanaActiva = ventana;
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.modificarPN.Controls.Add(ventana);
            this.modificarPN.Tag = ventana;
            ventana.BringToFront();
            ventana.Show();
        }

        private void nuevoModeloBTN_Click(object sender, EventArgs e)
        {
            if (_idVentanaActiva != 0)
            {
                _idVentanaActiva = 0;

                VistaNuevoModelo vistaNuevoModelo = new VistaNuevoModelo(_presentador);
                AbrirVentana(vistaNuevoModelo);
            }
        }

        private void modificarModeloBTN_Click(object sender, EventArgs e)
        {
            if (_idVentanaActiva != 1)
            {
                _idVentanaActiva = 1;
                VistaModificarModelo vistaModificarModelo = new VistaModificarModelo(_presentador);
                AbrirVentana(vistaModificarModelo);
            }
        }

        private void eliminarModeloBTN_Click(object sender, EventArgs e)
        {
            if (_idVentanaActiva != 2)
            {
                _idVentanaActiva = 2;
                VistaEliminarModelo vistaEliminarModelo = new VistaEliminarModelo(_presentador);
                AbrirVentana(vistaEliminarModelo);
            }
        }
    }
}
