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
    public class Modelo
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModeloId { get; set; }
        [Required]
        [MaxLength(12)]
        public string SKU { get; set; }

        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int LimiteInferiorReproceso { get; set; }
        [Required]
        public int LimiteSuperiorReproceso { get; set; }
        [Required]
        public int LimiteInferiorObservado { get; set; }
        [Required]
        public int LimiteSuperiorObservado { get; set; }

        public int EstadoDeUsoId { get; set; }
        [ForeignKey("EstadoDeUsoId")]
        [Required]
        public virtual EstadoDeUso Estado { get; set; }

    }
}
