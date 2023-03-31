using Dominio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.DTOs.Enumeraciones;
using Dominio.Entidades;
using System.Runtime.Serialization;

namespace Aplicacion.DTOs
{
    [DataContract]
    public class LineaDeTrabajoDTO
    {
        [DataMember]
        public int LineaDeTrabajoId { get; set; }

        [DataMember]
        public int NumeroDeLinea { get; set; }
        
        [DataMember]
        public EstadoDeUsoDTO EstadoDeUso { get; set; }

        [DataMember]
        public EstadoDeLineaDTO EstadoDeLinea { get; set; }

        [DataMember]
        public SemaforoDTO SemaforoReproceso { get; set; }

        [DataMember]
        public SemaforoDTO SemaforoObservados { get; set; }

        public LineaDeTrabajoDTO()
        {
            EstadoDeLinea = new EstadoDeLineaDTO();
            EstadoDeUso = new EstadoDeUsoDTO();
        }

        public LineaDeTrabajoDTO(LineaDeTrabajo linea)
        {
            LineaDeTrabajoId = linea.LineaDeTrabajoId;
            NumeroDeLinea = linea.NumeroDeLinea;
            EstadoDeUso = new EstadoDeUsoDTO(linea.EstadoDeUso);
            EstadoDeLinea = new EstadoDeLineaDTO(linea.EstadoDeLinea);
            SemaforoReproceso = new SemaforoDTO(linea.SemaforoReproceso);
            SemaforoObservados = new SemaforoDTO(linea.SemaforoObservados);
        }

        public LineaDeTrabajo CrearClaseDominio()
        {
            LineaDeTrabajo auxiliar = new LineaDeTrabajo();
            auxiliar.LineaDeTrabajoId = LineaDeTrabajoId;
            auxiliar.NumeroDeLinea = NumeroDeLinea;
            auxiliar.EstadoDeUso = EstadoDeUso.CrearClaseDominio();
            auxiliar.EstadoDeLinea = EstadoDeLinea.CrearClaseDominio();
            auxiliar.SemaforoObservados = SemaforoObservados.CrearClaseDominio();
            auxiliar.SemaforoReproceso = SemaforoReproceso.CrearClaseDominio();
            return auxiliar;
        }


    }
}
