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
    public class AdministradorSesion : IAdministradorSesion
    {

        private IManagerDeDB _dB;


        public AdministradorSesion(IManagerDeDB dataBase)
        {
            _dB = dataBase;
        }

 
        public UsuarioDTO LogearUsuario(string cuenta, string password)
        {
            Usuario cliente =  _dB.LogearUsuario(cuenta,password);

            if (cliente==null) return null;
            return new UsuarioDTO(cliente);
        }













    }
}
