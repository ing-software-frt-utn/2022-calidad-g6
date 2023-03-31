using ConexionWeb.ConexionWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.IVistas
{
    public interface IVistaInspeccionarCalzado
    {
        void ExhibirApellidoYNombreSupervisor(string apellidoYNombre);
        void ExhibirDatosOp(string numeroOp, string numeroLinea, string modelo, string color);
        void CargarAmbasTablasDeDefectos(List<DefectoDTO> defectosReproceso, List<DefectoDTO> defectosObservado);
        void EstablecerHoraInicialInspeccion(string horaInicial);
    }
}
