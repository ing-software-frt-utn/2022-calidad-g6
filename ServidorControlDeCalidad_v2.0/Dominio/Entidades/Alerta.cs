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
    public class Alerta
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AlertaId { get; set; }

        [Required]
        public DateTime HoraParada { get; set; }

        public DateTime HoraReinicio { get; set; }

        public int OrdenDeProduccionId { get; set; }
        [ForeignKey("OrdenDeProduccionId")]
        [Required]
        public virtual OrdenDeProduccion Dueno { get; set; }


        public int CategoriaDefectoId { get; set; }
        [ForeignKey("CategoriaDefectoId")]
        [Required]
        public virtual CategoriaDefecto CausaDeLaAlarma { get; set; }



    }
}
