
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.DTOs.Enumeraciones;
using Dominio.Entidades;
using Dominio.Enumeraciones;
using System.Runtime.Serialization;

namespace Aplicacion.DTOs
{
    [DataContract]
    public class UsuarioDTO
    {

        [DataMember] 
        public int UsuarioId { get; set; }

        [DataMember] 
        public string CuentaDeUsuario { get; set; }

        [DataMember] 
        public string Password { get; set; }

        [DataMember] 
        public int Dni { get; set; }

        [DataMember] 
        public string Apellido { get; set; }

        [DataMember] 
        public string Nombre { get; set; }

        [DataMember] 
        public string Email { get; set; }

        [DataMember]
        public ClaseUsuarioDTO Puesto { get; set; }

        public UsuarioDTO()
        {
            Puesto = new ClaseUsuarioDTO();
        }

        public UsuarioDTO(Usuario usuario)
        {
            UsuarioId = usuario.UsuarioId;
            CuentaDeUsuario = usuario.CuentaDeUsuario;
            Password = usuario.Password;
            Dni = usuario.Dni;
            Apellido = usuario.Apellido;
            Nombre = usuario.Nombre;
            Email = usuario.Email;
            Puesto = new ClaseUsuarioDTO(usuario.Puesto);
        }

        public Usuario CrearClaseDominio()
        {
            Usuario auxiliar = new Usuario();
            auxiliar.UsuarioId = UsuarioId;
            auxiliar.CuentaDeUsuario = CuentaDeUsuario;
            auxiliar.Password = Password;
            auxiliar.Dni = Dni;
            auxiliar.Apellido = Apellido;
            auxiliar.Nombre = Nombre;
            auxiliar.Email = Email;
            if(Puesto != null)auxiliar.Puesto = Puesto.CrearClaseDominio();
            return auxiliar;
        }




    }
}
