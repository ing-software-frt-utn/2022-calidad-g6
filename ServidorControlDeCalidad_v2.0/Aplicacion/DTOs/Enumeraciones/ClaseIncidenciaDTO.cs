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
    public class ClaseIncidenciaDTO
    {
        [DataMember]
        public int ClaseIncidenciaId { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        public ClaseIncidenciaDTO()
        {

        }

        public ClaseIncidenciaDTO(ClaseIncidencia clase)
        {
            ClaseIncidenciaId = clase.ClaseIncidenciaId;
            Descripcion = clase.Descripcion;
        }

        public ClaseIncidencia CrearClaseDominio()
        {
            ClaseIncidencia auxiliar = new ClaseIncidencia();
            auxiliar.ClaseIncidenciaId = ClaseIncidenciaId;
            auxiliar.Descripcion = Descripcion;
            return auxiliar;

        }

    }
}
