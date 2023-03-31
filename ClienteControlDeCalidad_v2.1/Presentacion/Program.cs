using ConexionWeb;
using Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transversal;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            VerificadorDeEntradas verificador =  VerificadorDeEntradas.Instance;
            


            Application.Run(new VistaContenedor());
        }
    }
}
