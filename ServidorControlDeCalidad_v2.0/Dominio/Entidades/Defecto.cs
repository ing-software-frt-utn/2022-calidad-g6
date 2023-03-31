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
    public class Defecto
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DefectoId { get; set; }

        public string Descripcion { get; set; }

        public int CategoriaDefectoId { get; set; }
        [ForeignKey("CategoriaDefectoId")]
        public virtual CategoriaDefecto Categoria { get; set; }


    }
}
