using Aplicacion.Interfaces;
using Aplicacion.DTOs;
using Dominio.Entidades;
using Dominio.Interfaces_DB;
using Persistencia.ConexionConDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Enumeraciones;

namespace Aplicacion.Administradores
{
    public class AdministradorOP : IAdministradorOP
    {

        private IManagerDeDB _dB;

        public AdministradorOP(IManagerDeDB dataBase)
        {
            _dB = dataBase;
        }

        public bool InsertarOP(OrdenDeProduccionDTO nuevaOP)
        {
            OrdenDeProduccion op = nuevaOP.CrearClaseDominio();
            op.OrdenDeProduccionId = 1;

            op.SupervisorDeLinea = _dB.SeleccionarUsuario(nuevaOP.SupervisorDeLinea.UsuarioId);

            if (op.SupervisorDeLinea != null && op.SupervisorDeLinea.Puesto.ClaseUsuarioId == 2)
            {
                OrdenDeProduccion verificacion = _dB.SeleccionarOPActiva(op.SupervisorDeLinea.UsuarioId);
                if (verificacion == null)
                {

                    op.Estado = _dB.SeleccionarEtadoOP(2);
                    op.ModeloControlado = _dB.SeleccionarModelo(op.ModeloControlado.ModeloId);

                    if (op.ModeloControlado != null)
                    {
                        op.ColorModelo = _dB.SeleccionarColor(op.ColorModelo.ColorId);

                        if (op.ColorModelo != null)
                        {
                            List<JornadaLaboral> jornadas = new List<JornadaLaboral>();
                            List<Alerta> alertas = new List<Alerta>();
                            
                            op.NumeroDeLinea = _dB.SeleccionarLinea(op.NumeroDeLinea.LineaDeTrabajoId);

                            if (op.NumeroDeLinea != null && op.NumeroDeLinea.EstadoDeLinea.EstadoDeLineaId == 1)
                            {
                                op.FechaInicio = DateTime.Now;
                                bool resultado = _dB.InsertarOrdenDeProduccion(op);

                                if (resultado)
                                {
                                    op.NumeroDeLinea.EstadoDeLinea = _dB.SeleccionarEstadoDeLinea(2);

                                    return _dB.ActualizarLineaDeTrabajo(op.NumeroDeLinea);
                                }
                                

                            }


                        }


                    }                    


                }
                               

            }
            // deberia cambiar el bool por una clase error
            // Investigar patrones Aplicador-Suscriptor,Observador
            // Podemos disparar 
            return false;
        }

        public bool AsociarSupervisorCalidad(int supervisorId, int ordenDeProduccionId)
        {
            Usuario supervisor = _dB.SeleccionarUsuario(supervisorId);
            if (supervisor.Puesto.Descripcion.Equals("Supervisor De Calidad"))
            {
                OrdenDeProduccion ordenActual = _dB.SeleccionarOrdenDeProduccion(ordenDeProduccionId);
                if (ordenActual.Estado.Descripcion.Equals("PAUSADA"))
                {
                    ordenActual.SupervisorDeCalidad = supervisor;
                    return _dB.ActualizarOrdenDeProduccion(ordenActual);
                }
                

            }
            return false;
        }

        public bool DesasociarSupervisorCalidad(int supervisorId, int ordenDeProduccionId)
        {
            Usuario supervisor = _dB.SeleccionarUsuario(supervisorId);
            if (supervisor.Puesto.Descripcion.Equals("Supervisor De Calidad"))
            {
                OrdenDeProduccion ordenActual = _dB.SeleccionarOrdenDeProduccion(ordenDeProduccionId);
                if (ordenActual.Estado.Descripcion.Equals("ACTIVADA"))
                {
                    ordenActual.SupervisorDeCalidad = null;
                    return _dB.ActualizarOrdenDeProduccion(ordenActual);
                }


            }
            return false;
        }

        public bool PausarOrdenDeProduccion(int supervisorId, int ordenDeProduccionId)
        {
            Usuario supervisor = _dB.SeleccionarUsuario(supervisorId);
            if (supervisor.Puesto.Descripcion.Equals("Supervisor De Linea"))
            {
                OrdenDeProduccion ordenActual = _dB.SeleccionarOrdenDeProduccion(ordenDeProduccionId);
                if (ordenActual.Estado.Descripcion.Equals("ACTIVADA") && ordenActual.SupervisorDeCalidad == null)
                {
                    ordenActual.Estado = _dB.SeleccionarEtadoOP(2);
                    return _dB.ActualizarOrdenDeProduccion(ordenActual);
                }


            }
            return false;
        }

        public bool ActivarOrdenDeProduccion(int supervisorId, int ordenDeProduccionId)
        {
            Usuario supervisor = _dB.SeleccionarUsuario(supervisorId);
            if (supervisor.Puesto.Descripcion.Equals("Supervisor De Linea"))
            {
                OrdenDeProduccion ordenActual = _dB.SeleccionarOrdenDeProduccion(ordenDeProduccionId);
                if (ordenActual.Estado.Descripcion.Equals("PAUSADA") && ordenActual.SupervisorDeCalidad != null)
                {
                    ordenActual.Estado = _dB.SeleccionarEtadoOP(1);
                    return _dB.ActualizarOrdenDeProduccion(ordenActual);
                }


            }
            return false;
        }

        public bool FinalizarOrdenDeProduccion(int supervisorId, int ordenDeProduccionId)
        {
            Usuario supervisor = _dB.SeleccionarUsuario(supervisorId);
            if (supervisor.Puesto.Descripcion.Equals("Supervisor De Linea"))
            {
                OrdenDeProduccion ordenActual = _dB.SeleccionarOrdenDeProduccion(ordenDeProduccionId);
                if (ordenActual.Estado.Descripcion.Equals("PAUSADA") && ordenActual.SupervisorDeCalidad == null)
                {
                    LineaDeTrabajo linea = _dB.SeleccionarLinea(ordenActual.NumeroDeLinea.LineaDeTrabajoId);
                    linea.EstadoDeLinea = _dB.SeleccionarEstadoDeLinea(1);
                    _dB.ActualizarLineaDeTrabajo(linea);
                    ordenActual.Estado = _dB.SeleccionarEtadoOP(3);
                    return _dB.ActualizarOrdenDeProduccion(ordenActual);
                }


            }
            return false;
        }

        public SemaforoDTO ConsultarSemaforoObservados(int supervisorId, int ordenDeProduccionId)
        {

            Usuario supervisor = _dB.SeleccionarUsuario(supervisorId);
            if (supervisor.Puesto.Descripcion.Equals("Supervisor De Linea"))
            {
                OrdenDeProduccion ordenActual = _dB.SeleccionarOrdenDeProduccion(ordenDeProduccionId);
                SemaforoDTO aux = new SemaforoDTO(ordenActual.NumeroDeLinea.SemaforoObservados);
                return aux;

            }
            return null;
            
        }

        public SemaforoDTO ConsultarSemaforoReproceso(int supervisorId, int ordenDeProduccionId)
        {

            Usuario supervisor = _dB.SeleccionarUsuario(supervisorId);
            if (supervisor.Puesto.Descripcion.Equals("Supervisor De Linea"))
            {
                OrdenDeProduccion ordenActual = _dB.SeleccionarOrdenDeProduccion(ordenDeProduccionId);
                SemaforoDTO aux = new SemaforoDTO(ordenActual.NumeroDeLinea.SemaforoReproceso);
                return aux;

            }
            return null;

        }

        public bool ReinicarSemaforoReproceso(int supervisorId, int ordenDeProduccionId)
        {
            Usuario supervisor = _dB.SeleccionarUsuario(supervisorId);
            if (supervisor.Puesto.Descripcion.Equals("Supervisor De Linea"))
            {
                OrdenDeProduccion ordenActual = _dB.SeleccionarOrdenDeProduccion(ordenDeProduccionId);
                ordenActual.NumeroDeLinea.SemaforoReproceso.Valor = 0;
                ordenActual.NumeroDeLinea.SemaforoReproceso.Estado = _dB.SeleccionarEstadoSemaforo(1);
                return _dB.ActualizarOrdenDeProduccion(ordenActual);

            }
            return false;
        }

        public bool ReinicarSemaforoObservados(int supervisorId, int ordenDeProduccionId)
        {
            Usuario supervisor = _dB.SeleccionarUsuario(supervisorId);
            if (supervisor.Puesto.Descripcion.Equals("Supervisor De Linea"))
            {
                OrdenDeProduccion ordenActual = _dB.SeleccionarOrdenDeProduccion(ordenDeProduccionId);
                ordenActual.NumeroDeLinea.SemaforoObservados.Valor = 0;
                ordenActual.NumeroDeLinea.SemaforoObservados.Estado = _dB.SeleccionarEstadoSemaforo(1);
                return _dB.ActualizarOrdenDeProduccion(ordenActual);

            }
            return false;
        }

        public bool SupervisorPuedeCrearOP(int supervisorId)
        {
            Usuario supervisor = _dB.SeleccionarUsuario(supervisorId);
            if (supervisor.Puesto.Descripcion.Equals("Supervisor De Linea"))
            {
                OrdenDeProduccion ordenActual = _dB.SeleccionarOPActiva(supervisorId);
                if (ordenActual == null) return true;

            }
            return false;
        }

        public OrdenDeProduccionDTO ObtenerOPActualSupervisorDeCalidad(int supervisorId)
        {
            Usuario supervisor = _dB.SeleccionarUsuario(supervisorId);
            if (supervisor.Puesto.Descripcion.Equals("Supervisor De Calidad"))
            {
                OrdenDeProduccion ordenActual = _dB.SeleccionarOPActivaSupervisorDeCalidad(supervisorId);
                OrdenDeProduccionDTO respuesta = new OrdenDeProduccionDTO(ordenActual);
                return respuesta;

            }
            return null;
        }
    }
}
