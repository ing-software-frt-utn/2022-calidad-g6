using Presentacion.IVistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.IPresentadores
{
    public interface IPresentadorAutenticarUsuario 
    {
        void EstablecerVistas(IVistaAutenticarUsuario vistaAutenticarUsuario, IVistaContenedor vistaContenedor);
        void LogearUsuario(string cuenta, string password);

    }
}
