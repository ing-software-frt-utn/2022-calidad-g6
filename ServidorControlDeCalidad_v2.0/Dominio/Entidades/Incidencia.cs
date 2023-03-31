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
    public class Incidencia
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IncidenciaId { get; set; }
        [Required]
        public int Valor { get; set; }
        [Required]
        public DateTime Hora { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        [Required]
        public virtual Usuario Creador { get; set; }

        public int? PieId { get; set; }

        [ForeignKey("PieId")]
        public virtual Pie EncontradoEnPie { get; set; }

        public int ClaseIncidenciaId { get; set; }

        [ForeignKey("ClaseIncidenciaId")]
        public virtual ClaseIncidencia TipoIncidencia { get; set; }

        public int? DefectoId { get; set; }

        [ForeignKey("DefectoId")]
        public virtual Defecto DefectoEncontrado { get; set; }


        public int JornadaLaboralId { get; set; }

        [ForeignKey("JornadaLaboralId")]
        public virtual JornadaLaboral Dueno { get; set; }

    }
}
