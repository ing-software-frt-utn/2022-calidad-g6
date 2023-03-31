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
    public class EstadoDeLineaDTO
    {
        [DataMember]
        public int EstadoDeLineaId { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        public EstadoDeLineaDTO(EstadoDeLinea estado)
        {
            EstadoDeLineaId = estado.EstadoDeLineaId;
            Descripcion = estado.Descripcion;
        }

        public EstadoDeLineaDTO()
        {

        }
        public EstadoDeLinea CrearClaseDominio()
        {
            EstadoDeLinea auxiliar = new EstadoDeLinea();
            auxiliar.EstadoDeLineaId = EstadoDeLineaId;
            auxiliar.Descripcion = Descripcion;
            return auxiliar;
        }


    }
}
