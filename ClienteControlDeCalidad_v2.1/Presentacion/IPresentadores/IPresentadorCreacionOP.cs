using Presentacion.IVistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.IPresentadores
{
    public interface IPresentadorCreacionOP
    {
        void EstablecerVista(IVistaCreacionOP vista);
        string SeleccionarModelo();
        string SeleccionarLinea();
        string SeleccionarColor();
        void EstablecerSeleccion(int id);

        void LimpiarEntradas();

        void InsertarOp(string numeroOp);

    }
}
