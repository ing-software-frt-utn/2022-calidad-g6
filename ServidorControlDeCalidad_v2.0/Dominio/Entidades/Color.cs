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
    public class Color
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ColorId { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        public string Descripcion { get; set; }

        public int EstadoDeUsoId { get; set; }

        [ForeignKey("EstadoDeUsoId")]
        [Required]
        public virtual EstadoDeUso Estado { get; set; }

    }
}
