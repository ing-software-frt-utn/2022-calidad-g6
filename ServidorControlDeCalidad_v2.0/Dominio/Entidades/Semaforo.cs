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
    public class Semaforo
    {
        public int SemaforoId { get; set; }
        public virtual EstadoSemaforo Estado { get; set; }
        public int Valor { get; set; }
        public int LineaDeTrabajoId { get; set; }
        [ForeignKey("LineaDeTrabajoId")]
        [Required]
        public virtual LineaDeTrabajo Linea { get; set; }


    }
}
