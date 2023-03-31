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
    public class EstadoSemaforoDTO
    {
        [DataMember]
        public int EstadoSemaforoId { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        public EstadoSemaforoDTO()
        {

        }

        public EstadoSemaforoDTO(EstadoSemaforo estado)
        {
            EstadoSemaforoId = estado.EstadoSemaforoId;
            Descripcion = estado.Descripcion;
        }

        public EstadoSemaforo CrearClaseDominio()
        {
            EstadoSemaforo aux = new EstadoSemaforo();
            aux.EstadoSemaforoId = EstadoSemaforoId;
            if(aux.Descripcion != null)aux.Descripcion = Descripcion;

            return aux;
        }
    }
}
