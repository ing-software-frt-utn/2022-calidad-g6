using Aplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface IAdministradorModelos
    {

        bool InsertarModelo(ModeloDTO modelo);

        bool ActualizarModelo(ModeloDTO modelo);

        List<ModeloDTO> BuscarModelosPorDescripcion(string cadena);

        bool EliminarModelo(int modeloID);

        List<ModeloDTO> ObtenerModelosActivos();

        List<ModeloDTO> BuscarModelosPorSKU(string codigo);
    }
}
