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
    public class DefectoDTO
    {
        [DataMember]
        public int DefectoId { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public CategoriaDefectoDTO Categoria { get; set; }

        public DefectoDTO()
        {
            Categoria = new CategoriaDefectoDTO();
        }

        public DefectoDTO(Defecto defecto)
        {
            DefectoId = defecto.DefectoId;
            Descripcion = defecto.Descripcion;
            Categoria = new CategoriaDefectoDTO(defecto.Categoria);
        }

        public Defecto CrearClaseDominio()
        {
            Defecto auxiliar = new Defecto();
            auxiliar.DefectoId = DefectoId;
            auxiliar.Descripcion = Descripcion;
            if(Categoria != null) auxiliar.Categoria = Categoria.CrearClaseDominio();
            return auxiliar;

        }

    }
}
