using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using System.Runtime.Serialization;

namespace Aplicacion.DTOs
{
    [DataContract]
    public class TurnoDTO
    {
        [DataMember]
        public int TurnoId { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public int HoraInicio { get; set; }

        [DataMember]
        public int HoraFin { get; set; }

        public TurnoDTO()
        {

        }

        public TurnoDTO(Turno turno)
        {
            TurnoId = turno.TurnoId;
            Descripcion = turno.Descripcion;
            HoraInicio = turno.HoraInicio;
            HoraFin = turno.HoraFin;
        }

        public Turno CrearClaseDominio()
        {
            Turno auxiliar = new Turno();
            auxiliar.TurnoId = TurnoId;
            auxiliar.Descripcion = Descripcion;
            auxiliar.HoraInicio = HoraInicio;
            auxiliar.HoraFin = HoraFin;
            return auxiliar;
        }
    }
}
