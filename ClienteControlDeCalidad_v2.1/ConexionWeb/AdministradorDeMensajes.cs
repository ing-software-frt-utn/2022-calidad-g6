using ConexionWeb.ConexionWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionWeb
{
    public class AdministradorDeMensajes : IAdministradorDeMensajes
    {

        #region Definición de clase Singleton
        //Un singleton es una clase que solo se puede instanciar 1 vez.
        //Los llamados sucesivos al constructor de la clase devuelven la instancia que se creo previamente.
        //Todos los presentadores de este proyecto deben ser singletons para evitar conflictos.


        //Estas variables se utilizan para almacenar la intancia creada de la clase
        private static volatile AdministradorDeMensajes _instance;
        private static readonly object _syncLock = new object();


        // Utilizaremos un constructor de clase sin parametros
        public AdministradorDeMensajes()
        {

        }


        // Esta funcion crea y retorna la instancia de la clase si no existe, si existe una instancia creada la devuelve.
        // La instrucción lock evita que se cree más de una instancia, en caso de llamadas simultaneas a la función.
        public static AdministradorDeMensajes Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new AdministradorDeMensajes();
                    }
                }
                return _instance;
            }
        }

        #endregion

        public UsuarioDTO LoguearUsuario(string cuenta, string password)
        {
            using ( var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.LogearUsuario(cuenta, password);
            }
        }

        public List<ModeloDTO> ObtenerModelos()
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.ObtenerModelosActivos();
            }
        }

        public List<ModeloDTO> BuscarModeloPorDescripcion(string cadena)
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.BuscarModelosPorDescripcion(cadena);
            }
        }

        public List<ModeloDTO> BuscarModeloPorSku(string cadena)
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.BuscarModelosPorSKU(cadena);
            }
        }

        public bool CrearNuevoModelo(ModeloDTO nuevoModelo)
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.InsertarModelo(nuevoModelo);
            }
        }

        public JornadaLaboralDTO ObtenerJornada(int supervisorId, int opId) // S
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.ObtenerJornada(supervisorId, opId);
            }
        }

        public OrdenDeProduccionDTO ObtenerOrdenDeProduccionSupervisorCalidad(int supervisorId)
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.BuscarOPActualSupervisorDeCalidad(supervisorId);
            }
        }

        public List<DefectoDTO> ObtenerDefectosReproceso()
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.ObtenerDefectosDeReproceso();
            }
        }
        public List<DefectoDTO> ObtenerDefectosObservado()
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.ObtenerDefectosDeObservados();
            }
        }
        public List<IncidenciaDTO> ObtenerIncidenciasJornadaActual(int supervisorId, int opId)
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.ObtenerJornada(supervisorId, opId).Incidencias;
            }
        }
        public int ObtenerHoraInicioJornada(int supervisorId, int opId)
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.ObtenerJornada(supervisorId, opId).TurnoJornada.HoraInicio;
            }
        }
        public int ObtenerHoraFinJornada(int supervisorId, int opId)
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.ObtenerJornada(supervisorId, opId).TurnoJornada.HoraInicio;
            }
        }

        public bool RegistrarIncidencia(IncidenciaDTO incidencia)
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.InsertarIncidecia(incidencia);
            }
        }

        public List<LineaDeTrabajoDTO> ObtenerLineasDisponibles()
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.ObtenerLineasDeTrabajoDisponibles();
            }
        }

        public List<ColorDTO> ObtenerColoresActivos()
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.ObtenerColoresActivos();
            }
        }

        public bool InsertarOP(OrdenDeProduccionDTO ordenDeProduccion)
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.CrearOP(ordenDeProduccion);
            }
        }

        public bool EliminarModelo(int modeloId)
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.EliminarModelo(modeloId);
            }
        }

        public bool ActualizarModelo(ModeloDTO actualizacion)
        {
            using (var servicio = new ConexionWebService.ConexionClient())
            {
                return servicio.ActualizarModelo(actualizacion);
            }
        }


    }
}
