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
    public class Usuario
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }

        [MaxLength(30)]
        [Required]
        public string CuentaDeUsuario { get; set; }

        [MaxLength(30)]
        [Required]
        public string Password { get; set; }

        [Range(1000000,99999999)]
        [Required]
        public int Dni { get; set; }

        [MaxLength(30)]
        [Required]
        public string Apellido { get; set; }

        [MaxLength(30)]
        [Required]
        public string Nombre { get; set; }

        [MaxLength(40)]
        [Required]
        public string Email { get; set; }

        public int ClaseUsuarioId { get; set; }
        [ForeignKey("ClaseUsuarioId")]
        [Required]
        public virtual ClaseUsuario Puesto { get; set; }
    }
}
