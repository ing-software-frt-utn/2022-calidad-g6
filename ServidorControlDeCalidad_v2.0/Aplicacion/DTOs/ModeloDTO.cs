using Aplicacion.DTOs.Enumeraciones;
using Dominio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using System.Runtime.Serialization;

namespace Aplicacion.DTOs
{
    [DataContract]
    public class ModeloDTO
    {
        [DataMember]
        public int ModeloId { get; set; }

        [DataMember]
        public string SKU { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public int LimiteInferiorReproceso { get; set; }

        [DataMember]
        public int LimiteSuperiorReproceso { get; set; }

        [DataMember]
        public int LimiteInferiorObservado { get; set; }

        [DataMember]
        public int LimiteSuperiorObservado { get; set; }

        [DataMember]
        public EstadoDeUsoDTO Estado { get; set; }

        public ModeloDTO()
        {
            Estado = new EstadoDeUsoDTO();
        }

        public ModeloDTO(Modelo modelo)
        {
            ModeloId = modelo.ModeloId;
            SKU = modelo.SKU;
            Descripcion = modelo.Descripcion;
            LimiteInferiorReproceso = modelo.LimiteInferiorReproceso;
            LimiteSuperiorReproceso = modelo.LimiteSuperiorReproceso;
            LimiteInferiorObservado = modelo.LimiteInferiorObservado;
            LimiteSuperiorObservado = modelo.LimiteSuperiorObservado;
            Estado = new EstadoDeUsoDTO(modelo.Estado);


        }

        public Modelo CrearClaseDominio()
        {
            Modelo auxiliar = new Modelo();
            auxiliar.ModeloId = ModeloId;
            auxiliar.SKU = SKU;
            auxiliar.Descripcion = Descripcion;
            auxiliar.LimiteInferiorReproceso = LimiteInferiorReproceso;
            auxiliar.LimiteSuperiorReproceso = LimiteSuperiorReproceso;
            auxiliar.LimiteInferiorObservado = LimiteInferiorObservado;
            auxiliar.LimiteSuperiorObservado = LimiteSuperiorObservado;
            auxiliar.Estado = Estado.CrearClaseDominio();
            return auxiliar;
        }

    }
}
