using Aplicacion.Interfaces;
using Aplicacion.DTOs;
using Dominio.Entidades;
using Dominio.Interfaces_DB;
using System;
using System.Collections.Generic;


namespace Aplicacion.Administradores
{
    public class AdministradorDeLineas : IAdministradorDeLineas
    {
        private IManagerDeDB _dB;

        public AdministradorDeLineas(IManagerDeDB dataBase)
        {
            _dB = dataBase;
        }


        public bool ActualizarLineaDetrabajo(LineaDeTrabajoDTO actual)
        {
            LineaDeTrabajo temp = actual.CrearClaseDominio();
            return _dB.ActualizarLineaDeTrabajo(temp);
        }

        public bool EliminarLineaDetrabajo(int lineaID)
        {
            LineaDeTrabajo temp = _dB.SeleccionarLinea(lineaID);
            return _dB.ActualizarLineaDeTrabajo(temp);
        }

        public bool InsertarLineaDetrabajo(LineaDeTrabajoDTO lineaNueva)
        {
            LineaDeTrabajo temp = lineaNueva.CrearClaseDominio();
            temp.LineaDeTrabajoId = 1;
            return _dB.InsertarLineaDeTrabajo(temp);
        }

        public List<LineaDeTrabajoDTO> ObtenerLineasDeTrabajo()
        {
            List<LineaDeTrabajo> lineas = _dB.ObtenerLineasDeTrabajo();

            List<LineaDeTrabajoDTO> respuesta = new List<LineaDeTrabajoDTO>();

            if (lineas !=  null )
            {
                if (lineas.Count > 0)
                {
                    foreach (var item in lineas)
                    {
                        LineaDeTrabajoDTO temp = new LineaDeTrabajoDTO(item);
                        respuesta.Add(temp);
                    }
                }
            }
            


            return respuesta;
        }

        public List<LineaDeTrabajoDTO> ObtenerLineasDeTrabajoDisponibles()
        {
            List<LineaDeTrabajo> lineas = _dB.ObtenerLineasDeTrabajoDisponibles();

            List<LineaDeTrabajoDTO> respuesta = new List<LineaDeTrabajoDTO>();

            if (lineas != null)
            {
                if (lineas.Count > 0)
                {
                    foreach (var item in lineas)
                    {
                        LineaDeTrabajoDTO temp = new LineaDeTrabajoDTO(item);
                        respuesta.Add(temp);
                    }
                }
            }
            


            return respuesta;
        }
    }
}
