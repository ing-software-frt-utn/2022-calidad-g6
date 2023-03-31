using ConexionWeb.ConexionWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionWeb
{
    public interface IAdministradorDeMensajes
    {

        UsuarioDTO LoguearUsuario(string cuenta, string password);
        List<ModeloDTO> ObtenerModelos();
        List<ModeloDTO> BuscarModeloPorDescripcion(string cadena);
        List<ModeloDTO> BuscarModeloPorSku(string cadena);
        bool CrearNuevoModelo(ModeloDTO nuevoModelo);
        JornadaLaboralDTO ObtenerJornada(int supervisorId, int opId);
        OrdenDeProduccionDTO ObtenerOrdenDeProduccionSupervisorCalidad(int supervisorId);

        List<DefectoDTO> ObtenerDefectosReproceso();
        List<DefectoDTO> ObtenerDefectosObservado();
        int ObtenerHoraInicioJornada(int supervisorId, int opId);
        int ObtenerHoraFinJornada(int supervisorId, int opId);
        List<IncidenciaDTO> ObtenerIncidenciasJornadaActual(int supervisorId, int opId);
        bool RegistrarIncidencia(IncidenciaDTO incidencia);


        List<LineaDeTrabajoDTO> ObtenerLineasDisponibles();

        List<ColorDTO> ObtenerColoresActivos();

        bool InsertarOP(OrdenDeProduccionDTO ordenDeProduccionDTO);

        bool EliminarModelo(int modeloId);
        bool ActualizarModelo(ModeloDTO actualizacion);

    }
}
