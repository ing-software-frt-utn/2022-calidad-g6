using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.IVistas
{
    public interface IVistaAutenticarUsuario
    {
        #region Firmas de mostrar mensaje
        bool MostrarMensaje(string title, string messageInfo, bool cancelOption);
        bool MostrarMensaje(string title, string messageInfo, bool cancelOption, Image icon, Color wantedColor);
        #endregion
    }
}
