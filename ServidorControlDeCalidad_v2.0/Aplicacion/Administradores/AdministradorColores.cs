using Aplicacion.Interfaces;
using Aplicacion.DTOs;
using Dominio.Entidades;
using Dominio.Interfaces_DB;
using System.Collections.Generic;


namespace Aplicacion.Administradores
{
    public class AdministradorColores : IAdministradorColores
    {
        private IManagerDeDB _dB;

        public AdministradorColores(IManagerDeDB dataBase)
        {
            _dB = dataBase;
        }

        public List<ColorDTO> BuscarColoresPorCodigo(string codigo)
        {
            List<Color> resultadoBusqueda = _dB.BuscarColorPorCodigo(codigo);

            List<ColorDTO> respuesta = new List<ColorDTO>();

            foreach (var item in resultadoBusqueda)
            {
                ColorDTO temp = new ColorDTO(item);
                respuesta.Add(temp);
            }
            return respuesta;
        }

        public List<ColorDTO> BuscarColoresPorDescripcion(string cadena)
        {
            List<Color> resultadoBusqueda = _dB.BuscarColorPorNombre(cadena);

            List<ColorDTO> respuesta = new List<ColorDTO>();

            foreach (var item in resultadoBusqueda)
            {
                ColorDTO temp = new ColorDTO(item);
                respuesta.Add(temp);
            }
            return respuesta;
        }

        public List<ColorDTO> ObtenerColoresActivos()
        {
            List<Color> resultadoBusqueda = _dB.ObtenerColoresActivos();

            List<ColorDTO> respuesta = new List<ColorDTO>();

            foreach (var item in resultadoBusqueda)
            {
                ColorDTO temp = new ColorDTO(item);
                respuesta.Add(temp);
            }
            return respuesta;
        }

        public bool InsertarColor(ColorDTO nuevoColor)
        {
            Color temporal = nuevoColor.CrearClaseDominio();
            temporal.ColorId = 1;
            return _dB.InsertarColor(temporal);
        }

        public bool ActualizarColor(ColorDTO actualizacion)
        {
            Color temporal = actualizacion.CrearClaseDominio();
            return _dB.ActualizarColor(temporal);
        }

        public bool EliminarColor(int colorId)
        {
            return _dB.EliminarColor(colorId);
        }
    }
}
