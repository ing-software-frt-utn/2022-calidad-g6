using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.DTOs;

namespace Aplicacion.Interfaces
{
    public interface IAdministradorJornadaLaboral
    {

        JornadaLaboralDTO ObtenerJornada(int supervisorId,int opId);
        bool FinalizarJornada(int jornadaId);
        bool InsertarIncidecia(IncidenciaDTO nuevaIncidencia);

        List<DefectoDTO> ObtenerDefectosReproceso();
        List<DefectoDTO> ObtenerDefectosObservados();
        DefectoDTO SeleccionarDefecto(int defectoId);


    }
}
