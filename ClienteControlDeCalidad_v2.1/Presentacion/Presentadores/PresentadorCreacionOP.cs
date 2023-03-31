using ConexionWeb;
using Presentacion.IPresentadores;
using Presentacion.IVistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion.Vistas;
using ConexionWeb.ConexionWebService;
using System.Drawing;

namespace Presentacion.Presentadores
{
    public class PresentadorCreacionOP : IPresentadorCreacionOP
    {
        private IAdministradorDeMensajes _administradorDeMensajes = AdministradorDeMensajes.Instance;
        private IVistaCreacionOP _vista;
        private int _seleccionIndex = -99;
        private ModeloDTO _modeloSeleccionado = new ModeloDTO();
        private LineaDeTrabajoDTO _lineaSeleccionada = new LineaDeTrabajoDTO();
        private ColorDTO _colorSeleccionado = new ColorDTO();

        #region Definición de clase Singleton
        //Un singleton es una clase que solo se puede instanciar 1 vez.
        //Los llamados sucesivos al constructor de la clase devuelven la instancia que se creo previamente.
        //Todos los presentadores de este proyecto deben ser singletons para evitar conflictos.


        //Estas variables se utilizan para almacenar la intancia creada de la clase
        private static volatile PresentadorCreacionOP _instance;
        private static readonly object _syncLock = new object();


        // Utilizaremos un constructor de clase sin parametros
        public PresentadorCreacionOP()
        {
            
        }


        // Esta funcion crea y retorna la instancia de la clase si no existe, si existe una instancia creada la devuelve.
        // La instrucción lock evita que se cree más de una instancia, en caso de llamadas simultaneas a la función.
        public static PresentadorCreacionOP Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new PresentadorCreacionOP();
                    }
                }
                return _instance;
            }
        }


        #endregion

        public void EstablecerVista(IVistaCreacionOP vista)
        {
            _vista = vista;
            IniciarValoresSeleccion();

        }

        public string SeleccionarModelo()
        {
            _seleccionIndex = -99;
            VistaSeleccionLMSC seleccion = new VistaSeleccionLMSC("Modelo",this);
            List<ModeloDTO> listado = _administradorDeMensajes.ObtenerModelos();
            foreach (var item in listado)
            {
                seleccion.CargarFilaListado(item.ModeloId, item.Descripcion);
            }
            seleccion.ShowDialog();
            if (_seleccionIndex >= 0)
            {
                _modeloSeleccionado = listado.Find(x => x.ModeloId == _seleccionIndex);
                return _modeloSeleccionado.Descripcion;
            }
            else
            {
                return string.Empty;
            }

        }

        public string SeleccionarLinea()
        {
            _seleccionIndex = -99;
            VistaSeleccionLMSC seleccion = new VistaSeleccionLMSC("Linea", this);
            List<LineaDeTrabajoDTO> listado = _administradorDeMensajes.ObtenerLineasDisponibles();
            foreach (var item in listado)
            {
                seleccion.CargarFilaListado(item.LineaDeTrabajoId, $"Linea {item.NumeroDeLinea}");
            }
            seleccion.ShowDialog();
            if (_seleccionIndex >= 0)
            {
                _lineaSeleccionada = listado.Find(x => x.LineaDeTrabajoId == _seleccionIndex);
                return $"Linea {_lineaSeleccionada.NumeroDeLinea}";
            }
            else
            {
                return string.Empty;
            }
        }

        public string SeleccionarColor()
        {
            _seleccionIndex = -99;
            VistaSeleccionLMSC seleccion = new VistaSeleccionLMSC("Color", this);
            List<ColorDTO> listado = _administradorDeMensajes.ObtenerColoresActivos();
            foreach (var item in listado)
            {
                seleccion.CargarFilaListado(item.ColorId, item.Descripcion);
            }
            seleccion.ShowDialog();
            if (_seleccionIndex >= 0)
            {
                _colorSeleccionado = listado.Find(x => x.ColorId == _seleccionIndex);
                return _colorSeleccionado.Descripcion;
            }
            else
            {
                return string.Empty;
            }
        }

        public void EstablecerSeleccion(int id)
        {
            _seleccionIndex = id;
        }

        public void LimpiarEntradas()
        {
            IniciarValoresSeleccion();
        }

        private void IniciarValoresSeleccion()
        {
            _modeloSeleccionado.ModeloId = -99;
            _colorSeleccionado.ColorId = -99;
            _lineaSeleccionada.LineaDeTrabajoId = -99;
        }

        public void InsertarOp(string numeroOp)
        {
            if(numeroOp != "000000")
            {
                if (_modeloSeleccionado.ModeloId > 0 && _colorSeleccionado.ColorId > 0 && _lineaSeleccionada.LineaDeTrabajoId > 0)
                {
                    OrdenDeProduccionDTO ordenNueva = new OrdenDeProduccionDTO();
                    ordenNueva.OrdenDeProduccionId = 1;
                    ordenNueva.NumeroOP = int.Parse(numeroOp);
                    ordenNueva.ModeloControlado = _modeloSeleccionado;
                    ordenNueva.ColorModelo = _colorSeleccionado;
                    ordenNueva.NumeroDeLinea = _lineaSeleccionada;
                    ordenNueva.SupervisorDeLinea = Sesion.Instance.UsuarioLogueado;
                    bool respuesta = _administradorDeMensajes.InsertarOP(ordenNueva);
                    if (respuesta)
                    {
                        _vista.MostrarMensaje("Inserción exitosa", "Se ingresó correctamente la nueva OP", false, null, Color.FromArgb(10, 90, 10));
                    }
                    else
                    {
                        _vista.MostrarMensaje("Inserción Fallida", "No se puede crear la OP. Verifique los datos e intente nuevamente", false, null, Color.FromArgb(90, 10, 10));
                    }
                }
                else
                {
                    _vista.MostrarMensaje("Datos Faltantes", "Falta Seleccionar al menos un dato de la OP", false, null, Color.FromArgb(90, 10, 10));
                }
                
            }
            else
            {
                _vista.MostrarMensaje("Entrada Invalida","Debe asignar un numero de Op Mayor que 0",false,null, Color.FromArgb(90, 10, 10));
            }
        }
    }
}
