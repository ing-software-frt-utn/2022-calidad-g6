using Aplicacion.Interfaces;
using Aplicacion.DTOs;
using Dominio.Entidades;
using Dominio.Interfaces_DB;
using Persistencia.ConexionConDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Administradores
{
    public class AdministradorUsuarios : IAdministradorUsuarios
    {

        private IManagerDeDB _dB;

        public AdministradorUsuarios(IManagerDeDB dataBase)
        {
            _dB = dataBase;
        }


        public bool ActualizarUsuario(UsuarioDTO nuevoUsuario)
        {
            Usuario temporal = nuevoUsuario.CrearClaseDominio();
            return _dB.EditarUsuario(temporal);
        }

        public bool EliminarUsuario(int usuarioId)
        {
            return _dB.EliminarUsuario(usuarioId);
        }

        public bool InsertarUsuario(UsuarioDTO nuevoUsuario)
        {
            Usuario temporal = nuevoUsuario.CrearClaseDominio();
            temporal.UsuarioId = 1;
            return _dB.InsertarUsuario(temporal);
        }

        public List<UsuarioDTO> ObtenerTodosLosUsuarios()
        {
            List<Usuario> resultado = _dB.ObtenerTodosLosUsuarios();
            List<UsuarioDTO> respuesta = new List<UsuarioDTO>();
            if(resultado != null)
            {
                if (resultado.Count > 0)
                {
                    foreach (var item in resultado)
                    {
                        UsuarioDTO aux = new UsuarioDTO(item);
                        respuesta.Add(aux);
                    }
                }
            }
            return respuesta;
        }

        public UsuarioDTO SeleccionarUsuario(int id)
        {
            Usuario temporal = _dB.SeleccionarUsuario(id);
            if(temporal != null)
            {
                return new UsuarioDTO(temporal);
            }
            return null;
        }

        public List<UsuarioDTO> ObtenerSupervisoresDeCalidadDisponibles()
        {
            List<Usuario> supervisores = _dB.ObtenerSupervisoresDeCalidadDisponibles();

            List<UsuarioDTO> respuesta = new List<UsuarioDTO>();

            if (supervisores != null)
            {
                if (supervisores.Count > 0)
                {
                    foreach (var item in supervisores)
                    {
                        UsuarioDTO temp = new UsuarioDTO(item);
                        respuesta.Add(temp);
                    }
                }
            }


            return respuesta;

        }
    }
}
