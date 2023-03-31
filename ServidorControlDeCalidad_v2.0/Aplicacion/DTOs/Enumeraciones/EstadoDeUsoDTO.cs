using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Enumeraciones;
using System.Runtime.Serialization;

namespace Aplicacion.DTOs.Enumeraciones
{
    [DataContract]
    public class EstadoDeUsoDTO
    {
        [DataMember]
        public int EstadoDeUsoId { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        public EstadoDeUsoDTO(EstadoDeUso estado)
        {
            EstadoDeUsoId = estado.EstadoDeUsoId;
            Descripcion = estado.Descripcion;

        }

        public EstadoDeUsoDTO()
        {

        }
        public EstadoDeUso CrearClaseDominio()
        {
            EstadoDeUso auxiliar = new EstadoDeUso();
            auxiliar.EstadoDeUsoId = EstadoDeUsoId;
            auxiliar.Descripcion = Descripcion;
            return auxiliar;

        }


    }
}
