using Aplicacion.DTOs.Enumeraciones;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Aplicacion.DTOs
{
    [DataContract]
    public class SemaforoDTO
    {
        [DataMember]
        public int SemaforoId { get; set; }

        [DataMember]
        public EstadoSemaforoDTO Estado{ get; set; }

        [DataMember]
        public int Valor { get; set; }

        public SemaforoDTO()
        {

        }

        public SemaforoDTO(Semaforo semaforo)
        {
            SemaforoId = semaforo.SemaforoId;
            Estado = new EstadoSemaforoDTO(semaforo.Estado);
            Valor = semaforo.Valor;
        }

        public Semaforo CrearClaseDominio()
        {
            Semaforo aux = new Semaforo();
            aux.SemaforoId = SemaforoId;
            aux.Estado = Estado.CrearClaseDominio();
            aux.Valor = Valor;

            return aux;
        }

    }
}
