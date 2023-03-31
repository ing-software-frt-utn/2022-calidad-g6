using ConexionWeb;
using ConexionWeb.ConexionWebService;
using Presentacion.IPresentadores;
using Presentacion.IVistas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Presentadores
{
    public class PresentadorAutenticarUsuario : IPresentadorAutenticarUsuario
    {
        private IAdministradorDeMensajes _conexion = AdministradorDeMensajes.Instance;
        private IVistaAutenticarUsuario _vistaAutenticarUsuario;
        private IVistaContenedor _vistaContenedor;

        #region Definición de clase Singleton
        //Un singleton es una clase que solo se puede instanciar 1 vez.
        //Los llamados sucesivos al constructor de la clase devuelven la instancia que se creo previamente.
        //Todos los presentadores de este proyecto deben ser singletons para evitar conflictos.


        //Estas variables se utilizan para almacenar la intancia creada de la clase
        private static volatile PresentadorAutenticarUsuario _instance;
        private static readonly object _syncLock = new object();


        // Utilizaremos un constructor de clase sin parametros
        public PresentadorAutenticarUsuario()
        {

        }


        // Esta funcion crea y retorna la instancia de la clase si no existe, si existe una instancia creada la devuelve.
        // La instrucción lock evita que se cree más de una instancia, en caso de llamadas simultaneas a la función.
        public static PresentadorAutenticarUsuario Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new PresentadorAutenticarUsuario();
                    }
                }
                return _instance;
            }
        }



        #endregion

        public void EstablecerVistas(IVistaAutenticarUsuario vistaAutenticarUsuario, IVistaContenedor vistaContenedor)
        {
            _vistaAutenticarUsuario = vistaAutenticarUsuario;
            _vistaContenedor = vistaContenedor;
        }


        public void LogearUsuario(string cuenta, string password)
        {
            bool errorDeLogueo = false;

            if(cuenta!= "" && password != "")
            {
                UsuarioDTO resultado = _conexion.LoguearUsuario(cuenta, password);



                if (resultado == null)
                {
                    errorDeLogueo = true;
                }
                else
                {
                    Sesion sesion = Sesion.Instance;
                    sesion.UsuarioLogueado = resultado;
                    //aqui deberian navegar a la siguiente ventana
                    //_vistaAutenticarUsuario.MostrarMensaje("Logueo Exitoso", "Bienvenido al Sistema", false, null, Color.FromArgb(10, 90, 10));
                    _vistaContenedor.NavegarAVentanaDeUsuario(resultado.Puesto.ClaseUsuarioId);
                }
            }
            else
            {
                errorDeLogueo = true;
            }

            if (errorDeLogueo)
            {
                _vistaAutenticarUsuario.MostrarMensaje("Error de Logueo", "Usuario o contraseña invalido.\nPor favor intente nuevamente.", false, null, Color.FromArgb(90, 10, 10));
            }


        }


    }
}
