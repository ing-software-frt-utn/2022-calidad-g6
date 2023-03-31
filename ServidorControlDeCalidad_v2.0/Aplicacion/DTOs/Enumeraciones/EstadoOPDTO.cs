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
    public class EstadoOPDTO
    {
        [DataMember]
        public int EstadoOPId { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        public EstadoOPDTO(EstadoOP estado)
        {
            EstadoOPId = estado.EstadoOPId;
            Descripcion = estado.Descripcion;
        }

        public EstadoOPDTO()
        {

        }
        public EstadoOP CrearClaseDominio()
        {
            EstadoOP auxiliar = new EstadoOP();
            auxiliar.EstadoOPId = EstadoOPId;
            auxiliar.Descripcion = Descripcion;
            return auxiliar;
        }
    }
}
