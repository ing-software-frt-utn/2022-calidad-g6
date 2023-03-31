using Aplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface IAdministradorOP
    {

        bool InsertarOP(OrdenDeProduccionDTO nuevaOP);
        bool AsociarSupervisorCalidad(int supervisorId, int ordenDeProduccionId);
        bool DesasociarSupervisorCalidad(int supervisorId, int ordenDeProduccionId);
        bool PausarOrdenDeProduccion(int supervisorId, int ordenDeProduccionId);
        bool ActivarOrdenDeProduccion(int supervisorId, int ordenDeProduccionId);
        bool FinalizarOrdenDeProduccion(int supervisorId, int ordenDeProduccionId);
        SemaforoDTO ConsultarSemaforoObservados(int supervisorId, int ordenDeProduccionId);
        SemaforoDTO ConsultarSemaforoReproceso(int supervisorId, int ordenDeProduccionId);
        bool ReinicarSemaforoReproceso(int supervisorId, int ordenDeProduccionId);
        bool ReinicarSemaforoObservados(int supervisorId, int ordenDeProduccionId);
        bool SupervisorPuedeCrearOP(int supervisorId);
        OrdenDeProduccionDTO ObtenerOPActualSupervisorDeCalidad(int supervisorId);

    }
}
