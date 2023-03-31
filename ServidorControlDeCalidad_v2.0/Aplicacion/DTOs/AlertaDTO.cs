using Aplicacion.DTOs.Enumeraciones;
using Dominio.Entidades;
using Dominio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DTOs
{
    [DataContract]
    public class AlertaDTO
    {

        [DataMember]
        public int AlertaId { get; set; }

        [DataMember]
        public DateTime HoraParada { get; set; }

        [DataMember]
        public DateTime HoraReinicio { get; set; }

        [DataMember]
        public OrdenDeProduccionDTO Dueno { get; set; }

        [DataMember]
        public CategoriaDefectoDTO CausaDeLaAlarma { get; set; }

        public AlertaDTO()
        {
            Dueno = new OrdenDeProduccionDTO();
            CausaDeLaAlarma = new CategoriaDefectoDTO();
        }

        public AlertaDTO(Alerta alerta)
        {
            AlertaId = alerta.AlertaId;
            HoraParada = alerta.HoraParada;
            HoraReinicio = alerta.HoraReinicio;
            CausaDeLaAlarma = new CategoriaDefectoDTO(alerta.CausaDeLaAlarma);
            Dueno = new OrdenDeProduccionDTO();
            Dueno.OrdenDeProduccionId = alerta.OrdenDeProduccionId;
        }

        public Alerta CrearClaseDominio()
        {
            Alerta auxiliar = new Alerta();
            auxiliar.AlertaId = AlertaId;
            auxiliar.HoraParada = HoraParada;
            auxiliar.HoraReinicio = HoraReinicio;
            auxiliar.CausaDeLaAlarma = CausaDeLaAlarma.CrearClaseDominio();
            auxiliar.OrdenDeProduccionId = Dueno.OrdenDeProduccionId;
            return auxiliar;
        }

    }
}
