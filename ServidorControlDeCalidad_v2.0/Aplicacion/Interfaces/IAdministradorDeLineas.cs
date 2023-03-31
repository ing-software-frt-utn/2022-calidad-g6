using Aplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface IAdministradorDeLineas
    {

        List<LineaDeTrabajoDTO> ObtenerLineasDeTrabajo();

        List<LineaDeTrabajoDTO> ObtenerLineasDeTrabajoDisponibles();

        bool InsertarLineaDetrabajo(LineaDeTrabajoDTO lineaNueva);

        bool ActualizarLineaDetrabajo(LineaDeTrabajoDTO actual);

        bool EliminarLineaDetrabajo(int lineaID);
    }
}
