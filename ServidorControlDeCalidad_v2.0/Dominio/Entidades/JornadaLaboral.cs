using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class JornadaLaboral
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JornadaLaboralId { get; set; }
        [Required]
        public DateTime Fecha { get; set; }

        public int HoraFin { get; set; }

        public int HoraInicio { get; set; }

        public int[] Horas { get; set; }

        public virtual List<Incidencia> Incidencias { get; set; }

        public int TurnoId { get; set; }

        [ForeignKey("TurnoId")]
        [Required]
        public virtual Turno TurnoJornada { get; set; }


        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario SupervisorDeCalidad { get; set; }

        public int DuenoId { get; set; }

        [ForeignKey("DuenoId")]
        [Required]
        public virtual OrdenDeProduccion Dueno { get; set; }



        public JornadaLaboral()
        {

        }
        public JornadaLaboral(OrdenDeProduccion creador, DateTime fecha, Turno turnoActual, Usuario supervisorCalidad)
        {
            HoraInicio = fecha.Hour;
            DuenoId = creador.OrdenDeProduccionId;
            Dueno = creador;
            TurnoJornada = turnoActual;
            TurnoId = turnoActual.TurnoId;
            SupervisorDeCalidad = supervisorCalidad;
            UsuarioId = supervisorCalidad.UsuarioId;
            Incidencias = new List<Incidencia>();
        }


        public void CargarListaDeHorasTrabajadas()
        {
            List<int> lista = new List<int>();

            int horaFinalizacion = HoraFin;
            if (HoraFin == 0) horaFinalizacion = 24;
            for (int i = HoraInicio; i < horaFinalizacion; i++)
            {
                lista.Add(i);
            }

            Horas = lista.ToArray();

        }









    }
}
