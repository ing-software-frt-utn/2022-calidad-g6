using ConexionWeb.ConexionWebService;
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
using Transversal;

namespace Presentacion.Vistas
{
    public partial class VistaContenedor : Form, IVistaContenedor
    {

        private int _clickMouseSostenido, _posicionXMouse, _posicionYMouse, _anchoActualVentana, _altoActualVentana, _anchoPrevio, _altoPrevio, _posicionPreviaX, _posicionPreviaY;
        private Form _ventanaActiva;
        public VistaContenedor()
        {
            InitializeComponent();
        }

        #region Botones Modo de Ventana
        private void minimizarBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void normalBTN_Click(object sender, EventArgs e)
        {

            this.Size = new Size(_anchoPrevio, _altoPrevio);
            this.Location = new Point(_posicionPreviaX, _posicionPreviaY);
            normalBTN.Visible = false;
            maximizarBTN.Visible = true;
        }

        private void maximizarBTN_Click(object sender, EventArgs e)
        {
            _posicionPreviaX = this.Location.X;
            _posicionPreviaY = this.Location.Y;
            _anchoPrevio = this.Size.Width;
            _altoPrevio = this.Size.Height;
            this.WindowState = FormWindowState.Maximized;
            _anchoActualVentana = this.Size.Width + 6;
            _altoActualVentana = this.Size.Height - 38;
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(_anchoActualVentana, _altoActualVentana);
            this.Location = new Point(Screen.FromControl(this).Bounds.Left - 10, Screen.FromControl(this).Bounds.Top - 10);
            maximizarBTN.Visible = false;
            normalBTN.Visible = true;
        }

        private void cerrarBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Mover Ventana

        private void ventanaPN_MouseUp(object sender, MouseEventArgs e)
        {
            _clickMouseSostenido = 0;
        }



        private void ventanaPN_MouseMove(object sender, MouseEventArgs e)
        {
            if (_clickMouseSostenido == 1)
            {
                this.SetDesktopLocation(MousePosition.X - _posicionXMouse, MousePosition.Y - _posicionYMouse);
            }
        }

        private void ventanaPN_MouseDown(object sender, MouseEventArgs e)
        {
            _clickMouseSostenido = 1;
            _posicionXMouse = e.X;
            _posicionYMouse = e.Y;
        }


        private void tituloLB_MouseUp(object sender, MouseEventArgs e)
        {
            _clickMouseSostenido = 0;
        }


        private void tituloLB_MouseMove(object sender, MouseEventArgs e)
        {
            if (_clickMouseSostenido == 1)
            {
                this.SetDesktopLocation(MousePosition.X - _posicionXMouse, MousePosition.Y - _posicionYMouse);
            }
        }

        private void tituloLB_MouseDown(object sender, MouseEventArgs e)
        {
            _clickMouseSostenido = 1;
            _posicionXMouse = e.X;
            _posicionYMouse = e.Y;
        }



        #endregion



        private void VistaContenedor_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = false;
            this.Text = "";
            normalBTN.Visible = false;


            VistaAutenticarUsuario vistaAutenticarUsuario = new VistaAutenticarUsuario(this);
            AbrirVentana(vistaAutenticarUsuario);

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
            this.vistaActivaPN.Controls.Add(ventana);
            this.vistaActivaPN.Tag = ventana;
            ventana.BringToFront();
            ventana.Show();
        }

        public void NavegarAVentanaDeUsuario(int tipoUsuario)
        {
            switch (tipoUsuario)
            {
                case 1: //Administrador.
                    VistaGestionarModelos vistaGestionarModelos = new VistaGestionarModelos(Presentadores.PresentadorGestionarModelos.Instance);
                    AbrirVentana(vistaGestionarModelos);
                    break;
                case 2: //Supervisor de línea.
                    VistaCreacionOP vistaCreacionOP = new VistaCreacionOP(Presentadores.PresentadorCreacionOP.Instance);
                    AbrirVentana(vistaCreacionOP);
                    break;
                case 3: //Supervisor de calidad.
                    VistaInspeccionarCalzado vistaInspeccionarCalzado = new VistaInspeccionarCalzado(Presentadores.PresentadorInspeccionarCalzado.Instance);
                    AbrirVentana(vistaInspeccionarCalzado);
                    break;
                
                default:
                    break;
            }
        }
    }
}
