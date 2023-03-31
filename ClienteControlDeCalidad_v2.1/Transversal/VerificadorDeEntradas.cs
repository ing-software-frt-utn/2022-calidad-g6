using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transversal
{
    public class VerificadorDeEntradas : IVerificadorDeEntradas
    {

        #region Definición de clase Singleton
        //Un singleton es una clase que solo se puede instanciar 1 vez.
        //Los llamados sucesivos al constructor de la clase devuelven la instancia que se creo previamente.
        //Todos los presentadores de este proyecto deben ser singletons para evitar conflictos.


        //Estas variables se utilizan para almacenar la intancia creada de la clase
        private static volatile VerificadorDeEntradas _instance;
        private static readonly object _syncLock = new object();


        // Utilizaremos un constructor de clase sin parametros
        public VerificadorDeEntradas()
        {

        }


        // Esta funcion crea y retorna la instancia de la clase si no existe, si existe una instancia creada la devuelve.
        // La instrucción lock evita que se cree más de una instancia, en caso de llamadas simultaneas a la función.
        public static VerificadorDeEntradas Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new VerificadorDeEntradas();
                    }
                }
                return _instance;
            }
        }


        #endregion


        public void SoloNumeros(TextBox sender)
        {
            var text = sender.Text;
            var pos = sender.SelectionStart;

            Regex rgx = new Regex("[^0-9]");

            text = rgx.Replace(text, "");

            sender.Text = text;

            sender.Select(Math.Max(pos, 0), 0);
        }

    }
}
