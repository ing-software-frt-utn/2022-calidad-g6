using Dominio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class OrdenDeProduccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrdenDeProduccionId { get; set; }
        [Required]
        public int NumeroOP { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int EstadoOPId { get; set; }

        [ForeignKey("EstadoOPId")]
        [Required]
        public virtual EstadoOP Estado { get; set; }

        public int ModeloId { get; set; }

        [ForeignKey("ModeloId")]
        [Required]
        public virtual Modelo ModeloControlado { get; set; }

        public int ColorId { get; set; }

        [ForeignKey("ColorId")]
        [Required]
        public virtual Color ColorModelo { get; set; }

        public int LineaDeTrabajoId { get; set; }

        [ForeignKey("LineaDeTrabajoId")]
        [Required]
        public virtual LineaDeTrabajo NumeroDeLinea { get; set; }

        public virtual List<JornadaLaboral> JornadasLaborales { get; set; }

        public List<int> AlertaId { get; set; }

        [ForeignKey("AlertaId")]
        public virtual List<Alerta> Alertas { get; set; }

        public int? UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario SupervisorDeCalidad { get; set; }

        public int SupervisorId { get; set; }
        [ForeignKey("SupervisorId")]
        [Required]
        public virtual Usuario SupervisorDeLinea { get; set; }


        public void CopiarDatosEn(OrdenDeProduccion destino)
        {
            destino.EstadoOPId = EstadoOPId;
            destino.Estado = Estado;
            if (AlertaId != null)
            {
                if (destino.AlertaId == null)
                {
                    destino.AlertaId = new List<int>();
                    destino.AlertaId = AlertaId;
                }
                else
                {
                    destino.AlertaId = AlertaId;
                }
            }

            if (Alertas !=  null)
            {
                if (destino.Alertas == null)
                {
                    destino.Alertas = new List<Alerta>();
                    destino.Alertas = Alertas;
                }
                else
                {
                    destino.Alertas = Alertas;
                }
            }

            if (JornadasLaborales != null)
            {
                if (destino.JornadasLaborales == null)
                {
                    destino.JornadasLaborales = new List<JornadaLaboral>();
                    destino.JornadasLaborales = JornadasLaborales;
                }
                else
                {
                    destino.JornadasLaborales = JornadasLaborales;
                }
            }

            
            
            if(FechaFin != null)
            {
                if(destino.FechaFin == null)
                {
                    destino.FechaFin = new DateTime();
                    destino.FechaFin = FechaFin;
                }
                else
                {
                    destino.FechaFin = FechaFin;
                }
            }

            destino.SupervisorDeLinea = SupervisorDeLinea;
            destino.SupervisorId = SupervisorId;

            if (SupervisorDeCalidad != null)
            {
                destino.SupervisorDeCalidad = SupervisorDeCalidad;
                destino.UsuarioId = UsuarioId;
            }

        }


        public void AgregarJornadaLaboral(Usuario supervisorDeCalidad, Turno turnoActual)
        {

            JornadaLaboral jornadaNueva = new JornadaLaboral(this,DateTime.Now,turnoActual, supervisorDeCalidad );

            JornadasLaborales.Add(jornadaNueva);

        } 








    }
}
