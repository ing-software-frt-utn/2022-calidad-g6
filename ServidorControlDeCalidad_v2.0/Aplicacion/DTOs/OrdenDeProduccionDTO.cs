using Aplicacion.DTOs.Enumeraciones;
using Dominio.Entidades;
using Dominio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Aplicacion.DTOs
{
    [DataContract]
    public class OrdenDeProduccionDTO
    {
        [DataMember]
        public int OrdenDeProduccionId { get; set; }

        [DataMember]
        public int NumeroOP { get; set; }

        [DataMember]
        public DateTime FechaInicio { get; set; }

        [DataMember]
        public DateTime FechaFin { get; set; }
        
        [DataMember]
        public EstadoOPDTO Estado { get; set; }

        [DataMember]
        public ModeloDTO ModeloControlado { get; set; }

        [DataMember]
        public ColorDTO ColorModelo { get; set; }

        [DataMember]
        public LineaDeTrabajoDTO NumeroDeLinea { get; set; }

        [DataMember]
        public List<JornadaLaboralDTO> JornadasLaborales { get; set; }

        [DataMember]
        public List<AlertaDTO> Alertas { get; set; }

        [DataMember]
        public UsuarioDTO SupervisorDeCalidad { get; set; }

        [DataMember]
        public UsuarioDTO SupervisorDeLinea { get; set; }

        public OrdenDeProduccionDTO()
        {
            Estado = new EstadoOPDTO();
            ModeloControlado = new ModeloDTO();
            ColorModelo = new ColorDTO();
            NumeroDeLinea = new LineaDeTrabajoDTO();
            JornadasLaborales = new List<JornadaLaboralDTO>();
            Alertas = new List<AlertaDTO>();
            SupervisorDeCalidad = new UsuarioDTO();
            SupervisorDeLinea = new UsuarioDTO();
        }

        public OrdenDeProduccionDTO(OrdenDeProduccion orden)
        {
            OrdenDeProduccionId = orden.OrdenDeProduccionId;
            NumeroOP = orden.NumeroOP;
            FechaInicio = orden.FechaInicio;
            if(orden.FechaFin != null)FechaFin = orden.FechaFin;
            Estado = new EstadoOPDTO(orden.Estado);
            ModeloControlado = new ModeloDTO(orden.ModeloControlado);
            ColorModelo = new ColorDTO(orden.ColorModelo);
            NumeroDeLinea = new LineaDeTrabajoDTO(orden.NumeroDeLinea);
            JornadasLaborales = new List<JornadaLaboralDTO>();
            if (orden.JornadasLaborales != null)
            {
                foreach (var item in orden.JornadasLaborales)
                {
                    JornadaLaboralDTO temporal = new JornadaLaboralDTO(item);
                    JornadasLaborales.Add(temporal);
                }
            }
            Alertas = new List<AlertaDTO>();
            if (orden.Alertas != null)
            {
                foreach (var item in orden.Alertas)
                {
                    AlertaDTO auxiliar = new AlertaDTO(item);
                    Alertas.Add(auxiliar);
                }
            }
            if (orden.SupervisorDeCalidad != null) SupervisorDeCalidad = new UsuarioDTO( orden.SupervisorDeCalidad );
            SupervisorDeLinea = new UsuarioDTO(orden.SupervisorDeLinea);
        }

        public OrdenDeProduccion CrearClaseDominio()
        {
            OrdenDeProduccion aux = new OrdenDeProduccion();
            aux.OrdenDeProduccionId = OrdenDeProduccionId;
            aux.NumeroOP = NumeroOP;
            aux.FechaInicio = FechaInicio;
            if (FechaFin != DateTime.MinValue)
            {
                aux.FechaFin = FechaFin;
            }
            else
            {
                aux.FechaFin = new DateTime(1900,1,1,7,0,0);
            }
            if(Estado != null)aux.Estado = Estado.CrearClaseDominio();
            aux.ModeloControlado = ModeloControlado.CrearClaseDominio();
            aux.ColorModelo = ColorModelo.CrearClaseDominio();
            aux.NumeroDeLinea = NumeroDeLinea.CrearClaseDominio();
            aux.JornadasLaborales = new List<JornadaLaboral>();
            if(JornadasLaborales != null &&  JornadasLaborales.Count > 0)
            {
                foreach (var item in JornadasLaborales)
                {
                    aux.JornadasLaborales.Add(item.CrearClaseDominio());
                }
            }
            aux.Alertas = new List<Alerta>();
            if (Alertas != null &&  Alertas.Count > 0)
            {
                foreach (var item in Alertas)
                {
                    aux.Alertas.Add(item.CrearClaseDominio());
                }
            }
            if (SupervisorDeCalidad != null) aux.SupervisorDeCalidad = SupervisorDeCalidad.CrearClaseDominio();

            aux.SupervisorDeLinea = SupervisorDeLinea.CrearClaseDominio();

            return aux;
        }




    }
}
