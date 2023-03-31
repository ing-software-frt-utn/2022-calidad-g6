using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Turno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TurnoId { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int HoraInicio { get; set; }

        [Required]
        public int HoraFin { get; set; }


        public int[] ObtenerHorasDesdeHoraActual(int? forzarHora = null)
        {
            int horaActual = -99;

            if (forzarHora != null)
            {
                horaActual = forzarHora.Value;
            }
            else
            {
                 horaActual = DateTime.Now.Hour;

            }
            

            if(HoraFin >= horaActual)
            {
                int cantidad = HoraFin - horaActual;
                int[] Horas = new int[cantidad];

                for (int i = 0 ; i < cantidad ; i++)
                {
                    Horas[i] = horaActual;
                    horaActual++;
                }
                return Horas;
            }
            else
            {
                return null;
            }

        }

        public bool EsDuranteElDia()
        {
            if (HoraFin > HoraInicio) return true;
            return false;
        }

        public int ObtenerTotalDeHoras(int? forzarHora = null)
        {
            int horaActual = -99;

            if (forzarHora != null)
            {
                horaActual = forzarHora.Value;
            }
            else
            {
                horaActual = DateTime.Now.Hour;

            }

            if (HoraFin >= horaActual)
            {
                int cantidad = HoraFin - horaActual;
                return cantidad;
            }
            else
            {
                return -99;
            }

        }



    }
}
