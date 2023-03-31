
using Aplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces
{
    public interface IAdministradorSesion
    {

        UsuarioDTO LogearUsuario(string cuenta, string password);

    }
}
