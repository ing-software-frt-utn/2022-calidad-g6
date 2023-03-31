using Dominio.Entidades;
using Dominio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces_DB
{
    public interface IManagerDeDB
    {

        #region Manejo de Enumeraciones
        //Geters Lista
        List<CategoriaDefecto> ObtenerCategoriasDefecto();

        List<ClaseIncidencia> ObtenerClasesIncidencia();

        List<ClaseUsuario> ObtenerClasesDeUsuario();

        List<EstadoOP> ObtenerEtadosOP();

        List<Pie> ObtenerPies();

        List<EstadoDeUso> ObtenerEstadosDeUso();

        List<EstadoDeLinea> ObtenerEstadosDeLinea();

        List<EstadoSemaforo> ObtenerEstadosSemaforo();

        //Geters Individuales

        CategoriaDefecto SeleccionarCategoriaDefecto(int id);

        ClaseIncidencia SeleccionarClaseIncidencia(int id);

        ClaseUsuario SeleccionarClaseDeUsuario(int id);

        EstadoOP SeleccionarEtadoOP(int id);

        Pie SeleccionarPie(int id);

        EstadoDeUso SeleccionarEstadoDeUso(int id);

        EstadoDeLinea SeleccionarEstadoDeLinea(int id);

        EstadoSemaforo SeleccionarEstadoSemaforo(int id);

        //Seters

        bool EstablecerCategoriasDefecto(List<CategoriaDefecto> categorias);

        bool EstablecerClasesIncidencia(List<ClaseIncidencia> clases);

        bool EstablecerClasesDeUsuario(List<ClaseUsuario> clases);

        bool EstablecerEtadosOP(List<EstadoOP> estados);

        bool EstablecerPies(List<Pie> pies);

        bool EstablecerEstadosDeUso(List<EstadoDeUso> estados);

        bool EstablecerEstadosDeLinea(List<EstadoDeLinea> estados);

        bool EstablecerEstadosSemaforo(List<EstadoSemaforo> estados);
        #endregion

        #region Manejo de Usuarios

        int ObtenerCuentasDeUsuarios();

        bool EstablecerUsuariosIniciales(List<Usuario> usuarios);

        bool InsertarUsuario(Usuario usuario);

        Usuario LogearUsuario(string cuenta, string password);

        List<Usuario> ObtenerSupervisoresDeCalidadDisponibles();

        Usuario SeleccionarUsuario(int id);

        bool EditarUsuario(Usuario actualizacion);
        bool EliminarUsuario(int usuarioId);
        List<Usuario> ObtenerTodosLosUsuarios();

        #endregion

        #region Manejo de Turnos

        int ObtenerCantidadDeTurnos();

        bool EstablecerTurnosIniciales(List<Turno> turnos);

        List<Turno> ObtenerTurnos();




        #endregion

        #region Manejo de Colores

        bool EstablecerColores(List<Color> colores);
        List<Color> ObtenerColores();

        List<Color> ObtenerColoresActivos();

        bool InsertarColor(Color color);

        bool ActualizarColor(Color Color);
        bool EliminarColor(int colorId);

        Color SeleccionarColor(int colorId);
        List<Color> BuscarColorPorCodigo(string codigo);
        List<Color> BuscarColorPorNombre(string nombre);

        #endregion

        #region Manejo de Modelos

        bool EstablecerModelos(List<Modelo> modelos);
        List<Modelo> ObtenerModelosActivos();

        bool InsertarModelo(Modelo modelo);

        bool ActualizarModelo(Modelo actual);
        bool EliminarModelo(int nodeloId);

        Modelo SeleccionarModelo(int modeloId);

        List<Modelo> BuscarModelosPorSKU(string sku);

        List<Modelo> BuscarModelosPorDescripcion(string descripcion);
        #endregion

        #region Manejo de Ordenes de Produccion

        bool EstablecerOrdenesDeProduccionIniciales(List<OrdenDeProduccion> ops);
        List<OrdenDeProduccion> ObtenerOrdenesDeProduccion();

        OrdenDeProduccion SeleccionarOrdenDeProduccion(int opId);

        bool InsertarOrdenDeProduccion(OrdenDeProduccion nuevaOp);

        bool ActualizarOrdenDeProduccion(OrdenDeProduccion actual);

        OrdenDeProduccion SeleccionarOPActiva(int supervisorDeLineaId);

        OrdenDeProduccion SeleccionarOPActivaSupervisorDeCalidad(int supervisorDeCalidadId);

        #endregion

        #region Manejo de Lineas De Trabajo

        bool EstablecerLineas(List<LineaDeTrabajo> lineas);
        List<LineaDeTrabajo> ObtenerLineasDeTrabajo();

        List<LineaDeTrabajo> ObtenerLineasDeTrabajoDisponibles();

        bool InsertarLineaDeTrabajo(LineaDeTrabajo linea);
        bool ActualizarLineaDeTrabajo(LineaDeTrabajo linea);
        bool EliminarLineaDeTrabajo(int lineaId);
        LineaDeTrabajo SeleccionarLinea(int lineaId);

        #endregion

        #region Manejo de Jornada Laboral

        JornadaLaboral SeleccionarJornadaLaboral(int jornadaId);
        JornadaLaboral RecuperarUltimaJornada(int supervisorId);
        bool InsertarNuevaJornada(JornadaLaboral nuevaJornada);
        bool FinalizarJornada(int jornadaId);


        #endregion

        #region Manejo de Defectos
        bool EstablecerDefectosIniciales(List<Defecto> defectos);
        Defecto SeleccionarDefecto(int id);

        List<Defecto> ObtenerDefectosDeReproceso();
        List<Defecto> ObtenerDefectosDeObservado();

        #endregion

        #region Manejo de Alertas

        bool InsertarAlerta(Alerta nuevaAlerta);
        Alerta SeleccionarAlerta(int alertaId);

        #endregion

        #region Manejo de Incidencias

        bool InsertarIncidecia(Incidencia nuevaIncidencia);
        bool EstablecerIncidencias(List<Incidencia> incidencias);
        List<Incidencia> ObtenerIncidencias();
        int ObtenerConteoActualDeDefecto(int jornadaId, int defectoId);
        int ObtenerConteoActualDeParesDePrimera(int jornadaId);

        #endregion

        #region Manejo de Semaforos

        List<Semaforo> ObtenerSemaforos();

        bool EstablecerSemaforos(List<Semaforo> semaforos);

        Semaforo SeleccionarSemaforo(int semaforoId);

        bool ActualizarSemaforo(Semaforo actualizacion);

        #endregion

    }
}
