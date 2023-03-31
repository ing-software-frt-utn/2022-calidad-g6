using Dominio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Aplicacion.DTOs.Enumeraciones
{
    [DataContract]
    public class ClaseUsuarioDTO
    {
        [DataMember]
        public int ClaseUsuarioId { get; set; }
        
        [DataMember]
        public string Descripcion { get; set; }

        public ClaseUsuarioDTO()
        {

        }
        public ClaseUsuarioDTO(ClaseUsuario tipoUsuario)
        {
            ClaseUsuarioId = tipoUsuario.ClaseUsuarioId;
            Descripcion = tipoUsuario.Descripcion;
        }

        public ClaseUsuario CrearClaseDominio()
        {
            ClaseUsuario auxiliar = new ClaseUsuario();
            auxiliar.ClaseUsuarioId = ClaseUsuarioId;
            auxiliar.Descripcion = Descripcion;
            return auxiliar;
        }

    }
}
