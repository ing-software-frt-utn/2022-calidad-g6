using Aplicacion.DTOs;
using Aplicacion.Interfaces;
using Dominio.Entidades;
using Dominio.Enumeraciones;
using Dominio.Interfaces_DB;
using System;
using System.Collections.Generic;


namespace Aplicacion.Administradores
{
    public class AdministradorJornadaLaboral : IAdministradorJornadaLaboral
    {
        private IManagerDeDB _dB;

        public AdministradorJornadaLaboral(IManagerDeDB dataBase)
        {
            _dB = dataBase;
        }

        public JornadaLaboralDTO ObtenerJornada(int supervisorId, int opId)
        {
            List<Turno> turnos = _dB.ObtenerTurnos();
            int horaActual = DateTime.Now.Hour;
            Turno turnoActual = new Turno();
            turnoActual.TurnoId = -99;
            foreach (var item in turnos)
            {
                if(item.HoraInicio <= horaActual && item.HoraFin > horaActual)
                {
                    turnoActual = item;
                    break;
                }
            }
            // verificar que el supervisor esté asociado a la op
            if(turnoActual.TurnoId != -99)
            {
                JornadaLaboral ultimaJornada = _dB.RecuperarUltimaJornada(supervisorId);
                if (ultimaJornada.Fecha.Date == DateTime.Now.Date)
                {
                    if (ultimaJornada.TurnoId == turnoActual.TurnoId)
                    {
                        return new JornadaLaboralDTO(ultimaJornada);
                    }

                }
                InsertarNuevaJornada(supervisorId,opId,turnoActual);
            }

            return null;

        }

        private bool InsertarNuevaJornada(int supervisorId,int opId ,Turno turnoActual)
        {
            JornadaLaboral nuevaJornada = new JornadaLaboral();
            nuevaJornada.JornadaLaboralId = 1;
            nuevaJornada.Dueno = _dB.SeleccionarOrdenDeProduccion(opId);
            nuevaJornada.DuenoId = nuevaJornada.Dueno.OrdenDeProduccionId;
            nuevaJornada.Fecha = DateTime.Now;
            nuevaJornada.HoraInicio = DateTime.Now.Hour;
            nuevaJornada.HoraFin = -99;
            nuevaJornada.TurnoJornada = turnoActual;
            nuevaJornada.TurnoId = turnoActual.TurnoId;
            nuevaJornada.UsuarioId = supervisorId;
            nuevaJornada.SupervisorDeCalidad = _dB.SeleccionarUsuario(supervisorId);
            return _dB.InsertarNuevaJornada(nuevaJornada);

        }

        public bool FinalizarJornada(int jornadaId)
        {
            return _dB.FinalizarJornada(jornadaId);
        }

        public bool InsertarIncidecia(IncidenciaDTO nuevaIncidencia)
        {
            Incidencia aux = nuevaIncidencia.CrearClaseDominio();
            aux.IncidenciaId = 1;
            
            Usuario usuario = _dB.SeleccionarUsuario(aux.Creador.UsuarioId);
            aux.Creador = usuario;
            aux.UsuarioId = usuario.UsuarioId;
            ClaseIncidencia tipo = _dB.SeleccionarClaseIncidencia(aux.TipoIncidencia.ClaseIncidenciaId);
            aux.TipoIncidencia = tipo;
            aux.ClaseIncidenciaId = tipo.ClaseIncidenciaId;
            Defecto defecto = new Defecto();
            if(tipo.ClaseIncidenciaId == 2)
            {
                defecto = _dB.SeleccionarDefecto((int)aux.DefectoEncontrado.DefectoId);
                aux.DefectoEncontrado = defecto;
                aux.DefectoId = defecto.DefectoId;
                Pie pie = _dB.SeleccionarPie((int)aux.EncontradoEnPie.PieId);
                aux.EncontradoEnPie = pie;
                aux.PieId = pie.PieId;
            }
            
            JornadaLaboral jornada = _dB.SeleccionarJornadaLaboral(aux.Dueno.JornadaLaboralId);
            aux.Dueno = jornada;
            aux.JornadaLaboralId = jornada.JornadaLaboralId;
            bool respuesta = _dB.InsertarIncidecia(aux);
            if(respuesta && tipo.ClaseIncidenciaId == 2 ) respuesta = ActualizarSemaforo(jornada.DuenoId, defecto.CategoriaDefectoId );

            return respuesta;


        }

        private bool ActualizarSemaforo(int opId, int tipoDefecto)
        {
            bool respuesta = false;
            OrdenDeProduccion op = _dB.SeleccionarOrdenDeProduccion(opId);
            
            if (tipoDefecto == 1)
            {
                int limiteSuperior = op.ModeloControlado.LimiteSuperiorReproceso;
                int limiteInferior = op.ModeloControlado.LimiteInferiorReproceso;
                op.NumeroDeLinea.SemaforoReproceso.Valor++;
                if (op.NumeroDeLinea.SemaforoObservados.Valor == limiteInferior)
                {
                    op.NumeroDeLinea.SemaforoObservados.Estado = _dB.SeleccionarEstadoSemaforo(2);

                }
                else if (op.NumeroDeLinea.SemaforoObservados.Valor == limiteSuperior)
                {
                    op.NumeroDeLinea.SemaforoObservados.Estado = _dB.SeleccionarEstadoSemaforo(3);
                    respuesta = InsertarAlerta(op.OrdenDeProduccionId,1);
                }

            }
            else if (tipoDefecto == 2)
            {
                int limiteSuperior = op.ModeloControlado.LimiteSuperiorObservado;
                int limiteInferior = op.ModeloControlado.LimiteInferiorObservado;
                op.NumeroDeLinea.SemaforoObservados.Valor++;
                if(op.NumeroDeLinea.SemaforoObservados.Valor == limiteInferior)
                {
                    op.NumeroDeLinea.SemaforoObservados.Estado = _dB.SeleccionarEstadoSemaforo(2);
                   
                }else if (op.NumeroDeLinea.SemaforoObservados.Valor == limiteSuperior)
                {
                    op.NumeroDeLinea.SemaforoObservados.Estado = _dB.SeleccionarEstadoSemaforo(3);
                    respuesta = InsertarAlerta(op.OrdenDeProduccionId,2);
                }
            }

            respuesta = _dB.ActualizarOrdenDeProduccion(op);

            return respuesta;
        }

        private bool InsertarAlerta(int opId, int categoriaDefectoId)
        {
            Alerta nueva = new Alerta();
            OrdenDeProduccion op = _dB.SeleccionarOrdenDeProduccion(opId);
            nueva.AlertaId = 1;
            nueva.HoraParada = DateTime.Now;
            nueva.HoraReinicio = new DateTime(1900,1,1,7,0,0);
            nueva.Dueno = op;
            nueva.OrdenDeProduccionId = op.OrdenDeProduccionId;
            nueva.CategoriaDefectoId = categoriaDefectoId;
            nueva.CausaDeLaAlarma = _dB.SeleccionarCategoriaDefecto(categoriaDefectoId);
            return _dB.InsertarAlerta(nueva);
        }

        public List<DefectoDTO> ObtenerDefectosReproceso()
        {
            List<Defecto> listado = _dB.ObtenerDefectosDeReproceso();
            List<DefectoDTO> respuesta = new List<DefectoDTO>();
            foreach (var item in listado)
            {
                DefectoDTO aux = new DefectoDTO(item);
                respuesta.Add(aux);
            }
            return respuesta;
        }

        public List<DefectoDTO> ObtenerDefectosObservados()
        {
            List<Defecto> listado = _dB.ObtenerDefectosDeObservado();
            List<DefectoDTO> respuesta = new List<DefectoDTO>();
            foreach (var item in listado)
            {
                DefectoDTO aux = new DefectoDTO(item);
                respuesta.Add(aux);
            }
            return respuesta;
        }

        public DefectoDTO SeleccionarDefecto(int defectoId)
        {
            Defecto aux = _dB.SeleccionarDefecto(defectoId);
            DefectoDTO respuesta = new DefectoDTO(aux);
            return respuesta;
        }
    }
}
