using Aplicacion.Interfaces;
using Aplicacion.DTOs;
using Dominio.Entidades;
using Dominio.Interfaces_DB;
using Persistencia.ConexionConDB;
using System;
using System.Collections.Generic;


namespace Aplicacion.Administradores
{
    public class AdministradorModelos : IAdministradorModelos
    {
        private IManagerDeDB _dB;

        public AdministradorModelos(IManagerDeDB dataBase)
        {
            _dB = dataBase;
        }

        public bool InsertarModelo(ModeloDTO modelo)
        {
            Modelo nuevoModelo = modelo.CrearClaseDominio();
            nuevoModelo.ModeloId = 1;
            nuevoModelo.EstadoDeUsoId = 1;
            nuevoModelo.Estado = _dB.SeleccionarEstadoDeUso(1);
            return _dB.InsertarModelo(nuevoModelo);
        }

        public bool ActualizarModelo(ModeloDTO modelo)
        {
            Modelo modeloActualizado = modelo.CrearClaseDominio();

            return _dB.ActualizarModelo(modeloActualizado);


        }

        public List<ModeloDTO> BuscarModelosPorDescripcion(string cadena)
        {

            List<Modelo> resultadoBusqueda =  _dB.BuscarModelosPorDescripcion(cadena);

            List<ModeloDTO> respuesta = new List<ModeloDTO>();

            foreach (var item in resultadoBusqueda)
            {
                ModeloDTO temp = new ModeloDTO(item);
                respuesta.Add(temp);
            }
            return respuesta;
        }

        public bool EliminarModelo(int modeloID)
        {
            return _dB.EliminarModelo(modeloID);
        }

        public List<ModeloDTO> ObtenerModelosActivos()
        {
            List<Modelo> modelos = _dB.ObtenerModelosActivos();

            List<ModeloDTO> respuesta = new List<ModeloDTO>();

            foreach (var item in modelos)
            {
                ModeloDTO temp = new ModeloDTO(item);
                respuesta.Add(temp);
            }

            return respuesta;
        }

        public List<ModeloDTO> BuscarModelosPorSKU(string codigo)
        {
            List<Modelo> resultadoBusqueda = _dB.BuscarModelosPorSKU(codigo);

            List<ModeloDTO> respuesta = new List<ModeloDTO>();

            foreach (var item in resultadoBusqueda)
            {
                ModeloDTO temp = new ModeloDTO(item);
                respuesta.Add(temp);
            }
            return respuesta;
        }















    }
}
