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
    public class PieDTO
    {

        [DataMember] 
        public int PieId { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        public PieDTO(Pie pie)
        {
            PieId = pie.PieId;
            Descripcion = pie.Descripcion;
        }
        public PieDTO()
        {

        }

        public Pie CrearClaseDominio()
        {
            Pie auxiliar = new Pie();
            auxiliar.PieId = PieId;
            auxiliar.Descripcion = Descripcion;
            return auxiliar;
        }

    }

    
}
