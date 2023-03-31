using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Vistas
{
    public partial class VistaMensaje : Form
    {
        private string _tiulo;
        private string _mensaje;
        private bool _conBotonCancelar;

        public VistaMensaje(string titulo, string mensaje, bool opcionCancelar)
        {
            InitializeComponent();

            _tiulo = titulo;
            _mensaje = mensaje;
            _conBotonCancelar = opcionCancelar;
        }

        public VistaMensaje(string titulo, string mensaje, bool opcionCancelar, Image icono, Color colorDeseado)
        {
            InitializeComponent();

            _tiulo = titulo;
            _mensaje = mensaje;
            _conBotonCancelar = opcionCancelar;
            iconoPN.BackgroundImage = icono;
            iconoPN.BackgroundImageLayout = ImageLayout.Zoom;

            titlePanel.BackColor = colorDeseado;
        }



        private void VistaMessage_Load(object sender, EventArgs e)
        {
            tituloLB.Text = _tiulo;
            messageInfo.Text = _mensaje;

            continuarBTN.DialogResult = DialogResult.OK;
            
            EscalarFuente(tituloLB);
            EscalarFuente(messageInfo);

            if (_conBotonCancelar)
            {
                cancelarBTN.DialogResult = DialogResult.Cancel;
                cancelarBTN.Visible = true;
            }
            else
            {
                cancelarBTN.Visible = false;
            }

        }

        private void EscalarFuente(Label etiqueta)
        {
            if (!etiqueta.Text.Equals(string.Empty))
            {
                SizeF tamañoDelTexto = TextRenderer.MeasureText(etiqueta.Text, etiqueta.Font);

                float relacionDeAltura = etiqueta.Height / tamañoDelTexto.Height;
                float relacionDeAncho = etiqueta.Width / tamañoDelTexto.Width;
                float relacionMinima = (relacionDeAltura < relacionDeAncho) ? relacionDeAltura : relacionDeAncho;

                float tamañoNuevo = etiqueta.Font.Size * relacionMinima;

                etiqueta.Font = new Font(etiqueta.Font.FontFamily, tamañoNuevo * 0.97f, etiqueta.Font.Style);


            }

        }


    }
}
