using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.DTOs.Enumeraciones;
using Dominio.Entidades;
using Dominio.Enumeraciones;
using System.Runtime.Serialization;

namespace Aplicacion.DTOs
{
    [DataContract]
    public class JornadaLaboralDTO
    {
        [DataMember]
        public int JornadaLaboralId { get; set; }

        [DataMember]
        public DateTime Fecha { get; set; }

        [DataMember]
        public int HoraFin { get; set; }

        [DataMember]
        public int HoraInicio { get; set; }

        [DataMember]
        public int[] Horas { get; set; }
        //verificar que datos sobran y reducir el tamaño del paquete
        [DataMember]
        public OrdenDeProduccionDTO Dueno { get; set; }

        [DataMember]
        public List<IncidenciaDTO> Incidencias { get; set; }

        [DataMember]
        public TurnoDTO TurnoJornada { get; set; }

        [DataMember]
        public UsuarioDTO SupervisorDeCalidad { get; set; }

        public JornadaLaboralDTO()
        {
            Incidencias = new List<IncidenciaDTO>();
            Dueno = new OrdenDeProduccionDTO();
            TurnoJornada = new TurnoDTO();
            SupervisorDeCalidad = new UsuarioDTO();
        }

        public JornadaLaboralDTO(JornadaLaboral jornada)
        {
            JornadaLaboralId = jornada.JornadaLaboralId;
            Fecha = jornada.Fecha;
            HoraFin = jornada.HoraFin;
            HoraInicio = jornada.HoraInicio;
            if (HoraFin >= 0)
            {
                jornada.CargarListaDeHorasTrabajadas();
                Horas = jornada.Horas;
            }

            TurnoJornada = new TurnoDTO(jornada.TurnoJornada);
            SupervisorDeCalidad = new UsuarioDTO(jornada.SupervisorDeCalidad);

            Dueno = new OrdenDeProduccionDTO();
            Dueno.OrdenDeProduccionId = jornada.Dueno.OrdenDeProduccionId;
            Incidencias = new List<IncidenciaDTO>();
            if (jornada.Incidencias != null)
            {
                foreach (var item in jornada.Incidencias)
                {
                    IncidenciaDTO auxiliar = new IncidenciaDTO(item);
                    Incidencias.Add(auxiliar);
                }
            }
            
        }

        public JornadaLaboral CrearClaseDominio()
        {
            JornadaLaboral auxiliar = new JornadaLaboral();
            auxiliar.JornadaLaboralId = JornadaLaboralId;
            auxiliar.Fecha = Fecha;
            auxiliar.HoraFin = HoraFin;
            auxiliar.HoraInicio = HoraInicio;
            if(Horas != null)auxiliar.Horas = Horas.ToArray();
            if(TurnoJornada != null) auxiliar.TurnoJornada = TurnoJornada.CrearClaseDominio();
            if(SupervisorDeCalidad != null) auxiliar.SupervisorDeCalidad = SupervisorDeCalidad.CrearClaseDominio();
            auxiliar.Dueno = new OrdenDeProduccion();
            if(Dueno != null) auxiliar.Dueno.OrdenDeProduccionId = Dueno.OrdenDeProduccionId;
            auxiliar.Incidencias = new List<Incidencia>();
            if (Incidencias != null && Incidencias.Count > 0)
            {
                foreach (var item in Incidencias)
                {
                    Incidencia temporal = item.CrearClaseDominio();
                    auxiliar.Incidencias.Add(temporal);
                }
            }
            

            return auxiliar;
        }


    }
}
