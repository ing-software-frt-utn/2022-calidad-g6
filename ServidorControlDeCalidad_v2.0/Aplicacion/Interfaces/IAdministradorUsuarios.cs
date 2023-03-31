using Aplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface IAdministradorUsuarios
    {
        bool InsertarUsuario(UsuarioDTO nuevoUsuario);
        bool ActualizarUsuario(UsuarioDTO nuevoUsuario);
        bool EliminarUsuario(int usuarioId);

        UsuarioDTO SeleccionarUsuario(int id);
        List<UsuarioDTO> ObtenerTodosLosUsuarios();
        List<UsuarioDTO> ObtenerSupervisoresDeCalidadDisponibles();


    }
}
