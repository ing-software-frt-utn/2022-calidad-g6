using Aplicacion.DTOs.Enumeraciones;
using Dominio.Entidades;
using Dominio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Collections;

namespace Aplicacion.DTOs
{
    [DataContract]
    public class IncidenciaDTO 
    {
        [DataMember]
        public int IncidenciaId { get; set; }

        [DataMember]
        public int Valor { get; set; }

        [DataMember]
        public DateTime Hora { get; set; }

        [DataMember]
        public UsuarioDTO Creador { get; set; }

        [DataMember]
        public PieDTO EncontradoEnPie { get; set; }

        [DataMember]
        public ClaseIncidenciaDTO TipoIncidencia { get; set; }

        [DataMember]
        public DefectoDTO DefectoEncontrado { get; set; }

        [DataMember]
        public JornadaLaboralDTO Dueno { get; set; }

        public IncidenciaDTO()
        {
            Creador = new UsuarioDTO();
            EncontradoEnPie = new PieDTO();
            TipoIncidencia = new ClaseIncidenciaDTO();
            DefectoEncontrado = new DefectoDTO();
            Dueno = new JornadaLaboralDTO();
        }

        public IncidenciaDTO(Incidencia incidencia)
        {
            IncidenciaId = incidencia.IncidenciaId;
            Valor = incidencia.Valor;
            Hora = incidencia.Hora;
            Creador = new UsuarioDTO();
            Creador.UsuarioId = incidencia.Creador.UsuarioId;
            Dueno = new JornadaLaboralDTO();
            Dueno.JornadaLaboralId = incidencia.Dueno.JornadaLaboralId;
            TipoIncidencia = new ClaseIncidenciaDTO(incidencia.TipoIncidencia);

            if (TipoIncidencia.ClaseIncidenciaId == 2)
            {
                EncontradoEnPie = new PieDTO(incidencia.EncontradoEnPie);
                DefectoEncontrado = new DefectoDTO(incidencia.DefectoEncontrado);
            }
            
        }

        public Incidencia CrearClaseDominio()
        {
            Incidencia auxiliar = new Incidencia();
            auxiliar.IncidenciaId = IncidenciaId;
            auxiliar.Valor = Valor;
            auxiliar.Hora = Hora;
            if(Creador != null) auxiliar.Creador = Creador.CrearClaseDominio();
            if(TipoIncidencia != null) auxiliar.TipoIncidencia = TipoIncidencia.CrearClaseDominio();            
            if(Dueno != null) auxiliar.Dueno = Dueno.CrearClaseDominio();
            if (TipoIncidencia != null && TipoIncidencia.ClaseIncidenciaId == 2)
            {
                auxiliar.DefectoEncontrado = DefectoEncontrado.CrearClaseDominio();
                auxiliar.EncontradoEnPie = EncontradoEnPie.CrearClaseDominio();
            }

                return auxiliar;
        }


    }
}
