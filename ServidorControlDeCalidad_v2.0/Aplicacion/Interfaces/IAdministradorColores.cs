using Aplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface IAdministradorColores
    {

        List<ColorDTO> BuscarColoresPorCodigo(string codigo);

        List<ColorDTO> BuscarColoresPorDescripcion(string cadena);

        List<ColorDTO> ObtenerColoresActivos();

        bool InsertarColor(ColorDTO nuevoColor);

        bool ActualizarColor(ColorDTO actualizacion);
        bool EliminarColor(int colorId);


    }
}
