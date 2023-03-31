using ConexionWeb;
using ConexionWeb.ConexionWebService;
using Presentacion.IPresentadores;
using Presentacion.IVistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Presentadores
{
    public class PresentadorInspeccionarCalzado: IPresentadorInspeccionarCalzado
    {
        private IAdministradorDeMensajes _administradorDeMensajes = AdministradorDeMensajes.Instance;
        private JornadaLaboralDTO _jornadaLaboral;
        private int _idUsuario;
        private int _horaSeleccionadaRegistroDeIncidencias;
        private int _contadorParesPrimera;
        private IVistaInspeccionarCalzado _vista;


        public void EstablecerVista(IVistaInspeccionarCalzado vista)
        {
            _vista = vista;
        }


        #region Definición de clase Singleton
        //Un singleton es una clase que solo se puede instanciar 1 vez.
        //Los llamados sucesivos al constructor de la clase devuelven la instancia que se creo previamente.
        //Todos los presentadores de este proyecto deben ser singletons para evitar conflictos.

        //Estas variables se utilizan para almacenar la intancia creada de la clase
        private static volatile PresentadorInspeccionarCalzado _instance;
        private static readonly object _syncLock = new object();


        // Utilizaremos un constructor de clase sin parametros
        public PresentadorInspeccionarCalzado()
        {

        }

        // Esta funcion crea y retorna la instancia de la clase si no existe, si existe una instancia creada la devuelve.
        // La instrucción lock evita que se cree más de una instancia, en caso de llamadas simultaneas a la función.
        public static PresentadorInspeccionarCalzado Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new PresentadorInspeccionarCalzado();
                    }
                }
                return _instance;
            }
        }

        #endregion

        public void CargarJornadaLaboral()
        {
            UsuarioDTO supervisorDeCalidad = Sesion.Instance.UsuarioLogueado;
            OrdenDeProduccionDTO op = _administradorDeMensajes.ObtenerOrdenDeProduccionSupervisorCalidad(supervisorDeCalidad.UsuarioId);
            _jornadaLaboral = _administradorDeMensajes.ObtenerJornada(supervisorDeCalidad.UsuarioId, op.OrdenDeProduccionId);
        }

        #region Recuperar datos de la cabecera de la vista

        public void ObtenerDatosCabecera()
        {
            ObtenerApellidoYNombreSupervisorCalidad();
            ObtenerDatosOP();
        }

        private void ObtenerApellidoYNombreSupervisorCalidad()
        {
            UsuarioDTO supervisorDeCalidad = Sesion.Instance.UsuarioLogueado;

            _idUsuario = supervisorDeCalidad.UsuarioId;
            string nombreSupervisor = $"{supervisorDeCalidad.Apellido} {supervisorDeCalidad.Nombre}";
            _vista.ExhibirApellidoYNombreSupervisor(nombreSupervisor);
        }

        private void ObtenerDatosOP()
        {

            UsuarioDTO supervisorDeCalidad = Sesion.Instance.UsuarioLogueado;
            OrdenDeProduccionDTO op = _administradorDeMensajes.ObtenerOrdenDeProduccionSupervisorCalidad(supervisorDeCalidad.UsuarioId);

            string numeroOp = op.NumeroOP.ToString();
            string numeroLinea = op.NumeroDeLinea.LineaDeTrabajoId.ToString();
            string modelo = op.ModeloControlado.Descripcion;
            string color = op.ColorModelo.Descripcion;
            _vista.ExhibirDatosOp(numeroOp, numeroLinea, modelo, color);

            _jornadaLaboral = _administradorDeMensajes.ObtenerJornada(supervisorDeCalidad.UsuarioId, op.OrdenDeProduccionId);
        }
        #endregion

        #region Mostrar los defectos en el datagrid (reproceso y observado)
        public List<DefectoDTO> ObtenerDefectosReproceso()
        {
            return _administradorDeMensajes.ObtenerDefectosReproceso();
        }
        public List<DefectoDTO> ObtenerDefectosObservado()
        {
            return _administradorDeMensajes.ObtenerDefectosObservado();
        }
        public List<IncidenciaDTO> ObtenerIncidenciasJornadaActual()
        {
            UsuarioDTO supervisorDeCalidad = Sesion.Instance.UsuarioLogueado;
            OrdenDeProduccionDTO op = _administradorDeMensajes.ObtenerOrdenDeProduccionSupervisorCalidad(supervisorDeCalidad.UsuarioId);

            return _administradorDeMensajes.ObtenerIncidenciasJornadaActual(supervisorDeCalidad.UsuarioId, op.OrdenDeProduccionId);
        }
        public int ContarDefectosDelTipoYPie(List<IncidenciaDTO> incidencias, int idDefecto, int pieId)
        {
            int contador = 0;
            foreach (var incidencia in incidencias)
            {
                if (incidencia.TipoIncidencia.ClaseIncidenciaId == 2)
                {
                    if (incidencia.DefectoEncontrado.DefectoId == idDefecto
                        && incidencia.EncontradoEnPie.PieId == pieId)
                    {
                        if (incidencia.Valor == 1)
                        {
                            contador++;
                        }
                        if (incidencia.Valor == -1)
                        {
                            contador--;
                        }
                    }

                }
            }
            return contador;
        }

        private void CargarTablaDefectosReproceso(List<DefectoDTO> defectos) // En este método se cargan los datos de cada modelo en cada una de las filas de la tabla.
        {

            foreach (var item in defectos)
            {
                int contadorPieDerecho;
                int contadorPieIzquierdo;

                contadorPieIzquierdo = ContarDefectosDelTipoYPie(ObtenerIncidenciasJornadaActual(), item.DefectoId, 1);
                contadorPieDerecho = ContarDefectosDelTipoYPie(ObtenerIncidenciasJornadaActual(), item.DefectoId, 2);

            }
        }
        #endregion

        #region Proceso de inspección, carga de datos iniciales
        public int ObtenerHoraInicioTurnoActual()
        {
            int horaInicio;

            horaInicio = _jornadaLaboral.TurnoJornada.HoraInicio;

            return horaInicio;
        }
        public int ObtenerHoraFinTurnoActual()
        {
            int horaFin;

            horaFin = _jornadaLaboral.TurnoJornada.HoraFin;
            return horaFin;
        }
        public int[] ObtenerHorasTurnoActual(int horaInicio, int horaFin)
        {
            int j = 0;
            int[] horasTurno = new int[24];
            for (int i = horaInicio; i < horaFin; i++)
            {
                horasTurno[j] = i;
            }
            return horasTurno;
        }
        public int ObtenerHoraActual()
        {
            int horaActual;

            horaActual = int.Parse(DateTime.Now.ToString("HH"));

            return horaActual;
        }
        public int ObtenerHoraActualFicticia()
        {
            int horaActual = 10;
            return horaActual;
        }
        public bool ComprobarHoraActualTurno(int horaActual, int horaInicioTurno, int horaFinTurno)
        {
            bool resultado = false;

            if (horaActual >= horaInicioTurno &&
                horaActual < horaFinTurno)
            {
                resultado = true;
            }
            return resultado;
        }
        public void InicializarHoraRegistroIncidencias()
        {
            //_horaSeleccionadaRegistroDeIncidencias = ObtenerHoraActual();
            _horaSeleccionadaRegistroDeIncidencias = ObtenerHoraActual();
        }
        public int ObtenerHoraSeleccionadaRegistroIncidencias()
        {
            int horaSeleccionada = _horaSeleccionadaRegistroDeIncidencias;

            return horaSeleccionada;
        }
        public string InicializarContadorParesPrimeraJornada()
        {
            _contadorParesPrimera = 0;
            string resultado;

            List<IncidenciaDTO> incidencias = ObtenerIncidenciasIniciales();
            foreach (var item in incidencias)
            {
                if (item.TipoIncidencia.ClaseIncidenciaId == 1)
                {
                    if (item.Valor == 1)
                    {
                        _contadorParesPrimera++;
                    }
                    if (item.Valor == -1)
                    {
                        _contadorParesPrimera--;
                    }
                }
            }
            resultado = _contadorParesPrimera.ToString();
            return resultado;
        }
        private List<IncidenciaDTO> ObtenerIncidenciasIniciales()
        {
            List<IncidenciaDTO> incidencias = _jornadaLaboral.Incidencias;
            return incidencias;
        }
        #endregion

        #region Proceso de inspección interacción con la vista

        public void IncrementarHoraSeleccionadaRegistroIncidencias()
        {
            if (_horaSeleccionadaRegistroDeIncidencias < _jornadaLaboral.TurnoJornada.HoraFin)
            {
                _horaSeleccionadaRegistroDeIncidencias++;
            }
        }

        public void DecrementarHoraSeleccionadaRegistroIncidencias()
        {
            if (_horaSeleccionadaRegistroDeIncidencias > _jornadaLaboral.TurnoJornada.HoraInicio)
            {
                _horaSeleccionadaRegistroDeIncidencias--;
            }
        }

        public void VolverAHoraRegistroIncidenciasActual()
        {
            _horaSeleccionadaRegistroDeIncidencias = ObtenerHoraActual();
        }

        #endregion

        #region Registrar incidencias
        public void RegistrarIncidenciaParDePrimera(int incrementoDecremento)
        {
            IncidenciaDTO incidencia = new IncidenciaDTO();

            incidencia.IncidenciaId = 1;
            incidencia.Valor = incrementoDecremento;
            incidencia.Hora = DateTime.Now.AddHours(_horaSeleccionadaRegistroDeIncidencias - ObtenerHoraActual());
            incidencia.Creador = new UsuarioDTO();
            incidencia.Creador.UsuarioId = _idUsuario;
            incidencia.Creador.Puesto = new ClaseUsuarioDTO();

            incidencia.TipoIncidencia = new ClaseIncidenciaDTO();
            incidencia.TipoIncidencia.ClaseIncidenciaId = 1;

            incidencia.Dueno = new JornadaLaboralDTO();
            incidencia.Dueno.JornadaLaboralId = _jornadaLaboral.JornadaLaboralId;

            incidencia.EncontradoEnPie = null;
            incidencia.DefectoEncontrado = null;

            if ((incrementoDecremento == 1 || _contadorParesPrimera > 0) && RegistrarIncidencia(incidencia))
            {
                IncrementarDecrementarParesDePrimera(incrementoDecremento);
            }

        }
        public void RegistrarIncidenciaDefecto(bool decremento, int defectoId, int pieId, int valorCelda)
        {
            int incrementoDecremento;
            IncidenciaDTO incidencia = new IncidenciaDTO();

            incidencia.IncidenciaId = 1; // Identificación de esta incidencia en concreto. Por defecto 1, lo corrige el servidor

            if (decremento)
            {
                incrementoDecremento = -1;//Es decremento
            }
            else
            {
                incrementoDecremento = 1;//Es incremento
            }
            incidencia.Valor = incrementoDecremento;
            incidencia.Hora = DateTime.Now.AddHours(_horaSeleccionadaRegistroDeIncidencias - ObtenerHoraActual());
            incidencia.Creador = new UsuarioDTO();
            incidencia.Creador.UsuarioId = _idUsuario;
            incidencia.Creador.Puesto = new ClaseUsuarioDTO();


            incidencia.TipoIncidencia = new ClaseIncidenciaDTO();
            incidencia.TipoIncidencia.ClaseIncidenciaId = 2;
            incidencia.Dueno = new JornadaLaboralDTO();
            incidencia.Dueno.JornadaLaboralId = _jornadaLaboral.JornadaLaboralId;

            incidencia.EncontradoEnPie = new PieDTO();
            incidencia.EncontradoEnPie.PieId = pieId;

            incidencia.DefectoEncontrado = new DefectoDTO();
            incidencia.DefectoEncontrado.DefectoId = defectoId;


            if ((incrementoDecremento == 1 || valorCelda > 0) && RegistrarIncidencia(incidencia))
            {
                _jornadaLaboral.Incidencias.Add(incidencia);
            }

        }
        private void IncrementarDecrementarParesDePrimera(int incrementoDecremento)
        {
            if (incrementoDecremento == 1)
            {
                _contadorParesPrimera++;
            }
            if (incrementoDecremento == -1)
            {
                _contadorParesPrimera--;
            }
        }
        public string ObtenerContadorParesDePrimeraActualizado()
        {
            string resultado;
            resultado = _contadorParesPrimera.ToString();
            return resultado;
        }
        private bool RegistrarIncidencia(IncidenciaDTO incidencia)
        {
            bool respuesta = false;
            respuesta = _administradorDeMensajes.RegistrarIncidencia(incidencia);
            return respuesta;
        }
        #endregion
    }
}