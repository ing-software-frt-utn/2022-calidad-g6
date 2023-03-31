using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Enumeraciones;
using System.Runtime.Serialization;

namespace Aplicacion.DTOs.Enumeraciones
{
    [DataContract]
    public class CategoriaDefectoDTO
    {
        [DataMember]
        public int CategoriaDefectoId { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        public CategoriaDefectoDTO()
        {

        }

        public CategoriaDefectoDTO(CategoriaDefecto categoria)
        {
            CategoriaDefectoId = categoria.CategoriaDefectoId;
            Descripcion = categoria.Descripcion;
        }

        public CategoriaDefecto CrearClaseDominio()
        {
            CategoriaDefecto auxiliar = new CategoriaDefecto();
            auxiliar.CategoriaDefectoId = CategoriaDefectoId;
            auxiliar.Descripcion = Descripcion;
            return auxiliar;
        }

    }
}
