
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.DTOs.Enumeraciones;
using Dominio.Entidades;
using Dominio.Enumeraciones;
using System.Runtime.Serialization;

namespace Aplicacion.DTOs
{
    [DataContract]
    public class ColorDTO
    {
        [DataMember]
        public int ColorId { get; set; }

        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public EstadoDeUsoDTO Estado { get; set; }

        public ColorDTO(Color colorDominio)
        {
            ColorId = colorDominio.ColorId;
            Codigo = colorDominio.Codigo;
            Descripcion = colorDominio.Descripcion;
            Estado = new EstadoDeUsoDTO(colorDominio.Estado);
        }

        public ColorDTO()
        {
            Estado = new EstadoDeUsoDTO();
        }

        public Color CrearClaseDominio()
        {
            Color auxiliar = new Color();
            auxiliar.ColorId = ColorId;
            auxiliar.Codigo = Codigo;
            auxiliar.Descripcion = Descripcion;
            auxiliar.EstadoDeUsoId = Estado.EstadoDeUsoId;

            return auxiliar;
        }


    }
}
