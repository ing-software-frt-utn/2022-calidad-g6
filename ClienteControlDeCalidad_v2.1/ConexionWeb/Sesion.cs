using ConexionWeb.ConexionWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionWeb
{
    public class Sesion
    {
        public UsuarioDTO UsuarioLogueado { get; set; }
        #region Definición de clase Singleton
        //Un singleton es una clase que solo se puede instanciar 1 vez.
        //Los llamados sucesivos al constructor de la clase devuelven la instancia que se creo previamente.
        //Todos los presentadores de este proyecto deben ser singletons para evitar conflictos.


        //Estas variables se utilizan para almacenar la intancia creada de la clase
        private static volatile Sesion _instance;
        private static readonly object _syncLock = new object();


        // Utilizaremos un constructor de clase sin parametros
        public Sesion()
        {

        }


        // Esta funcion crea y retorna la instancia de la clase si no existe, si existe una instancia creada la devuelve.
        // La instrucción lock evita que se cree más de una instancia, en caso de llamadas simultaneas a la función.
        public static Sesion Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Sesion();
                    }
                }
                return _instance;
            }
        }



        #endregion

    }
}
