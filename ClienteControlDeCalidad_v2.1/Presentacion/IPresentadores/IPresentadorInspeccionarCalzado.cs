using ConexionWeb.ConexionWebService;
using Presentacion.IVistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.IPresentadores
{
    public interface IPresentadorInspeccionarCalzado
    {
        void EstablecerVista(IVistaInspeccionarCalzado vista);
        void ObtenerDatosCabecera();
        List<DefectoDTO> ObtenerDefectosReproceso();
        List<DefectoDTO> ObtenerDefectosObservado();
        List<IncidenciaDTO> ObtenerIncidenciasJornadaActual();
        int ContarDefectosDelTipoYPie(List<IncidenciaDTO> incidencias, int idDefecto, int pieId);
        int ObtenerHoraInicioTurnoActual();
        int ObtenerHoraFinTurnoActual();
        int[] ObtenerHorasTurnoActual(int horaInicio, int horaFin);
        int ObtenerHoraActual();
        int ObtenerHoraActualFicticia(); // Es un reemplazo para probar el programa fuera de horas de turno
        bool ComprobarHoraActualTurno(int horaActual, int horaInicioTurno, int horaFinTurno);
        void InicializarHoraRegistroIncidencias();
        int ObtenerHoraSeleccionadaRegistroIncidencias();
        void IncrementarHoraSeleccionadaRegistroIncidencias();
        void DecrementarHoraSeleccionadaRegistroIncidencias();
        void VolverAHoraRegistroIncidenciasActual();
        void RegistrarIncidenciaParDePrimera(int incrementoDecremento);
        string InicializarContadorParesPrimeraJornada();
        string ObtenerContadorParesDePrimeraActualizado();
        void RegistrarIncidenciaDefecto(bool decremento, int defectoId, int pieId, int valorCelda);
        void CargarJornadaLaboral();

    }
}
