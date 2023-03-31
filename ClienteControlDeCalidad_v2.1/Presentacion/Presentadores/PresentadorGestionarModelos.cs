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
    public class PresentadorGestionarModelos : IPresentadorGestionarModelos
    {
        private IAdministradorDeMensajes _administradorDeMensajes = AdministradorDeMensajes.Instance;
        private IVistaGestionarModelos _vistaGestion;
        private IVistaNuevoModelo _vistaCreacion;
        private IVistaModificarModelo _vistaModificacion;
        private IVistaEliminarModelo _vistaEliminacion;
        private bool _buscarPorDescripcion = true;

        // Variables globales para retener los atributos iniciales del modelo seleccionado en la vista
        private ModeloDTO _inicialModeloSeleccionado = new ModeloDTO();
        //


        #region Definición de clase Singleton
        //Un singleton es una clase que solo se puede instanciar 1 vez.
        //Los llamados sucesivos al constructor de la clase devuelven la instancia que se creo previamente.
        //Todos los presentadores de este proyecto deben ser singletons para evitar conflictos.


        //Estas variables se utilizan para almacenar la intancia creada de la clase
        private static volatile PresentadorGestionarModelos _instance;
        private static readonly object _syncLock = new object();


        // Utilizaremos un constructor de clase sin parametros
        public PresentadorGestionarModelos()
        {

        }


        // Esta funcion crea y retorna la instancia de la clase si no existe, si existe una instancia creada la devuelve.
        // La instrucción lock evita que se cree más de una instancia, en caso de llamadas simultaneas a la función.
        public static PresentadorGestionarModelos Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new PresentadorGestionarModelos();
                    }
                }
                return _instance;
            }
        }
        #endregion

        public List<ModeloDTO> ObtenerModelos()
        {
            return _administradorDeMensajes.ObtenerModelos();
        }

        public void EstablecerReferenciaVistaGestion(IVistaGestionarModelos vista)
        {
            _vistaGestion = vista;
            _administradorDeMensajes = AdministradorDeMensajes.Instance;
        }

        public void EstablecerReferenciaVistaNuevo(IVistaNuevoModelo vista)
        {
            _vistaCreacion = vista;
        }

        public void EstablecerReferenciaVistaModificar(IVistaModificarModelo vista)
        {
            _vistaModificacion = vista;
        }

        public void EstablecerReferenciaVistaEliminar(IVistaEliminarModelo vista)
        {
            _vistaEliminacion = vista;
        }

        public void EstablecerMetodoBusqueda(bool eleccionSeleccion)
        {
            _buscarPorDescripcion = eleccionSeleccion;
        }

        public void CrearNuevoModelo(string sku, string denominacion, int limInfRep, int limSupRep, int limInfObs, int limSupObs)
        {
            ModeloDTO nuevoModelo = new ModeloDTO();

            nuevoModelo.SKU = sku;
            nuevoModelo.Descripcion = denominacion;

            
            nuevoModelo.LimiteInferiorReproceso = limInfRep;
            nuevoModelo.LimiteSuperiorReproceso = limSupRep;
            nuevoModelo.LimiteInferiorObservado = limInfObs;
            nuevoModelo.LimiteSuperiorObservado = limSupObs;
            
            nuevoModelo.Estado = new EstadoDeUsoDTO();

            bool respuesta = _administradorDeMensajes.CrearNuevoModelo(nuevoModelo);

            if (respuesta)
            {
                _vistaCreacion.MostrarMensaje("Creación Exitosa", "Se registró correctamente el\nnuevo modelo en la base de datos.", false, null, Color.FromArgb(10, 90, 10));
            }
            else
            {
                _vistaCreacion.MostrarMensaje("Error Inesperado", "Algo salió mal.\nCompruebe los datos ingresados\ne intente nuevamente.", false, null, Color.FromArgb(90, 10, 10));
            }

        }

        #region Comprobaciones de los campos de modelo (denominacion, límites), para modificar modelo
        
        public bool ComprobacionGeneralParaGuardarCambiosEnModelo(string denominacion, string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado)
        {
            bool resultado = false;
            if (
                ComprobarExistenciaDeModificacionesEnCampos(denominacion, limiteInferiorReproceso, limiteInferiorObservado, limiteSuperiorReproceso, limiteSuperiorObservado) &&
                !ComprobarSiAlgunCampoEstaVacio(denominacion, limiteInferiorReproceso, limiteInferiorObservado, limiteSuperiorReproceso, limiteSuperiorObservado) &&
                ComprobarQueLosLimitesSeanEnteros(limiteInferiorReproceso, limiteInferiorObservado, limiteSuperiorReproceso, limiteSuperiorObservado) &&
                ComprobarLimiteInferiorMenorASuperior(limiteInferiorReproceso, limiteInferiorObservado, limiteSuperiorReproceso, limiteSuperiorObservado)
                )
            {
                resultado = true;
            }
            return resultado;
        }
        public bool ComprobarExistenciaDeModificacionesEnCampos(string denominacion, string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado)
        {
            bool resultado = false;
            if (
                denominacion != _inicialModeloSeleccionado.Descripcion ||
                limiteInferiorReproceso != _inicialModeloSeleccionado.LimiteInferiorReproceso.ToString() ||
                limiteInferiorObservado != _inicialModeloSeleccionado.LimiteInferiorObservado.ToString() ||
                limiteSuperiorReproceso != _inicialModeloSeleccionado.LimiteSuperiorReproceso.ToString() ||
                limiteSuperiorObservado != _inicialModeloSeleccionado.LimiteSuperiorObservado.ToString()
                )
            {
                resultado = true;
            }
            return resultado;
        }
        public bool ComprobarSiAlgunCampoEstaVacio(string denominacion, string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado)
        {
            bool resultado = false;
            if (
                string.IsNullOrEmpty(denominacion) ||
                string.IsNullOrEmpty(limiteInferiorReproceso) ||
                string.IsNullOrEmpty(limiteInferiorObservado) ||
                string.IsNullOrEmpty(limiteSuperiorReproceso) ||
                string.IsNullOrEmpty(limiteSuperiorObservado)
                )
            {
                resultado = true;
            }
            return resultado;
        }

        public bool ComprobarQueLosLimitesSeanEnteros(string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado)
        {
            bool respuesta = false;
            if (
            Double.Parse(limiteInferiorReproceso) % 1 == 0 &&
            Double.Parse(limiteInferiorObservado) % 1 == 0 &&
            Double.Parse(limiteSuperiorReproceso) % 1 == 0 &&
            Double.Parse(limiteSuperiorObservado) % 1 == 0)
            {
                respuesta = true;
            }
            return respuesta;
        }
        public bool ComprobarLimiteInferiorMenorASuperior(string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado)
        {
            bool respuesta = false;
            if (
            Double.Parse(limiteInferiorReproceso) < Double.Parse(limiteSuperiorReproceso) &&
            Double.Parse(limiteInferiorObservado) < Double.Parse(limiteSuperiorObservado)
            )
            {
                respuesta = true;
            }
            return respuesta;
        }
        #endregion
        #region Comprobaciones para confirmar creación de modelo
        public bool ComprobarSiAlgunCampoEstaVacio(string sku, string denominacion, string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado)
        {
            bool resultado = false;
            if (
                string.IsNullOrEmpty(sku) ||
                string.IsNullOrEmpty(denominacion) ||
                string.IsNullOrEmpty(limiteInferiorReproceso) ||
                string.IsNullOrEmpty(limiteInferiorObservado) ||
                string.IsNullOrEmpty(limiteSuperiorReproceso) ||
                string.IsNullOrEmpty(limiteSuperiorObservado)
                )
            {
                resultado = true;
            }
            return resultado;
        }
        #endregion
        #region Guardar modificacion modelo
        public void GuardarModificacionModelo(int id, string denominacion, string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado)
        {
            // Que hayan cambios, que esté seleccionada una celda, que los límites sean números enteros, que no hayan campos nulos, que el límite inferior no se mayor al límite superior (ni iguales)
            // Comprobar que el campo por empty mas que por null. Puedo verificarlos a los 2, con empty sería suficiente.
            //Definir los métodos de comprobación como privados, solo los voy a necesitar en esta clase.
            ModeloDTO actualizacion = new ModeloDTO();
            actualizacion.ModeloId = id;
            actualizacion.Descripcion = denominacion;
            actualizacion.LimiteInferiorReproceso = int.Parse(limiteInferiorReproceso);
            actualizacion.LimiteInferiorObservado = int.Parse(limiteInferiorObservado);
            actualizacion.LimiteSuperiorReproceso = int.Parse(limiteSuperiorReproceso);
            actualizacion.LimiteSuperiorObservado = int.Parse(limiteSuperiorObservado);
            actualizacion.Estado = new EstadoDeUsoDTO();
            bool respuesta = _administradorDeMensajes.ActualizarModelo(actualizacion);

            if (respuesta)
            {
                _vistaModificacion.LimpiarSeleccion();
                _vistaModificacion.MostrarMensaje("Actualización Exitosa","Se modificó con exito el modelo\n en la base de datos.",false,null,Color.FromArgb(10,90,10));
            }
            else
            {
                _vistaModificacion.MostrarMensaje("Error Inesperado", "No se pudieron guardar los cambios.\nIntente nuevamente.", false, null, Color.FromArgb(90, 10, 10));
            }
                        
        }

        #endregion
        public void SetearValoresInicialesModeloSeleccionado(string denominacion, string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado)
        {
            _inicialModeloSeleccionado.Descripcion = denominacion;
            _inicialModeloSeleccionado.LimiteInferiorReproceso = int.Parse(limiteInferiorReproceso);
            _inicialModeloSeleccionado.LimiteSuperiorReproceso = int.Parse(limiteSuperiorReproceso);
            _inicialModeloSeleccionado.LimiteInferiorObservado = int.Parse(limiteInferiorObservado);
            _inicialModeloSeleccionado.LimiteSuperiorObservado = int.Parse(limiteSuperiorObservado);
        }

        public void EliminarModelo(int modeloId)
        {
            bool respuesta = _administradorDeMensajes.EliminarModelo(modeloId);

            if (respuesta)
            {
                _vistaEliminacion.MostrarMensaje("Eliminación Exitosa","Se eliminó correctamente el modelo seleccionado.",false,null,Color.FromArgb(10,90,10));
                _vistaEliminacion.ActualizarTabla();
            }
            else
            {
                _vistaEliminacion.MostrarMensaje("Error Inesperado", "Algo salió mal.\nIntente nuevamente.", false, null, Color.FromArgb(90, 10, 10));
            }
        }

        public void SetearMetodoDeBusqueda(bool buscarPorDescripcion)
        {
            _buscarPorDescripcion = buscarPorDescripcion;
        }

        public List<ModeloDTO> BuscarModelos(string busqueda)
        {
            if(busqueda != string.Empty)
            {
                if (_buscarPorDescripcion)
                {
                    return _administradorDeMensajes.BuscarModeloPorDescripcion(busqueda);
                }
                else
                {
                    return _administradorDeMensajes.BuscarModeloPorSku(busqueda);
                }
            }
            else
            {
                return ObtenerModelos();
            }
            
        }


    }

}