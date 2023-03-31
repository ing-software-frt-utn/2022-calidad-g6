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
    public class LineaDeTrabajo
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LineaDeTrabajoId { get; set; }
        public int NumeroDeLinea { get; set; }
        public int EstadoDeLineaId { get; set; }
        [ForeignKey("EstadoDeLineaId")]
        [Required]
        public virtual EstadoDeLinea EstadoDeLinea { get; set; }
        public int EstadoDeUsoId { get; set; }
        [ForeignKey("EstadoDeUsoId")]
        [Required]
        public virtual EstadoDeUso EstadoDeUso { get; set; }

        public virtual Semaforo SemaforoReproceso { get; set; }

        public virtual Semaforo SemaforoObservados { get; set; }

    }
}
