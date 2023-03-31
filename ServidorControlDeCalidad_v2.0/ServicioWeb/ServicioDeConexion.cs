
using Aplicacion.Interfaces;
using Aplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace ServicioWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServicioDeConexion : IConexion
    {

        private IAdministradorOP _adminOP;
        private Factoria _factoria = Factoria.Instance;

        #region Request para Administrador De Sesion

        public UsuarioDTO LogearUsuario(string cuenta, string password)
        {
            IAdministradorSesion adminSesion = _factoria.CrearAdministrador<IAdministradorSesion>();

            return adminSesion.LogearUsuario(cuenta, password);

        }

        #endregion

        #region Request para Administrador De Modelos

        public bool InsertarModelo(ModeloDTO modelo)
        {
            IAdministradorModelos adminModelos = _factoria.CrearAdministrador<IAdministradorModelos>();

            return adminModelos.InsertarModelo(modelo);

        }



        public bool ActualizarModelo(ModeloDTO modelo)
        {
            IAdministradorModelos adminModelos = _factoria.CrearAdministrador<IAdministradorModelos>();

            return adminModelos.ActualizarModelo(modelo);
        }


        public List<ModeloDTO> BuscarModelosPorDescripcion(string cadena)
        {
            IAdministradorModelos adminModelos = _factoria.CrearAdministrador<IAdministradorModelos>();

            return adminModelos.BuscarModelosPorDescripcion(cadena);
        }


        public bool EliminarModelo(int modeloID)
        {
            IAdministradorModelos adminModelos = _factoria.CrearAdministrador<IAdministradorModelos>();

            return adminModelos.EliminarModelo(modeloID);

        }

        public List<ModeloDTO> ObtenerModelosActivos()
        {
            IAdministradorModelos adminModelos = _factoria.CrearAdministrador<IAdministradorModelos>();

            return adminModelos.ObtenerModelosActivos();
        }


        public List<ModeloDTO> BuscarModelosPorSKU(string codigo)
        {
            IAdministradorModelos adminModelos = _factoria.CrearAdministrador<IAdministradorModelos>();

            return adminModelos.BuscarModelosPorSKU(codigo);
        }

        #endregion

        #region Request para Administrador De Colores

        public List<ColorDTO> BuscarColoresPorCodigo(string codigo)
        {
            IAdministradorColores adminColores = _factoria.CrearAdministrador<IAdministradorColores>();

            return adminColores.BuscarColoresPorCodigo(codigo);
        }

        public List<ColorDTO> BuscarColoresPorDescripcion(string cadena)
        {
            IAdministradorColores adminColores = _factoria.CrearAdministrador<IAdministradorColores>();

            return adminColores.BuscarColoresPorDescripcion(cadena);
        }

        public List<ColorDTO> ObtenerColoresActivos()
        {
            IAdministradorColores adminColores = _factoria.CrearAdministrador<IAdministradorColores>();

            return adminColores.ObtenerColoresActivos();
        }

        public bool EliminarColor(int colorId)
        {
            IAdministradorColores adminColores = _factoria.CrearAdministrador<IAdministradorColores>();

            return adminColores.EliminarColor(colorId);
        }

        public bool InsertarColor(ColorDTO nuevoColor)
        {
            IAdministradorColores adminColores = _factoria.CrearAdministrador<IAdministradorColores>();

            return adminColores.InsertarColor(nuevoColor);
        }

        public bool ActualizarColor(ColorDTO actualizacion)
        {
            IAdministradorColores adminColores = _factoria.CrearAdministrador<IAdministradorColores>();

            return adminColores.ActualizarColor(actualizacion);
        }

        #endregion

        #region Request para Administrador De Lineas

        public List<LineaDeTrabajoDTO> ObtenerLineasDeTrabajo()
        {
            IAdministradorDeLineas adminLineas = _factoria.CrearAdministrador<IAdministradorDeLineas>();

            return adminLineas.ObtenerLineasDeTrabajo();
        }

        public List<LineaDeTrabajoDTO> ObtenerLineasDeTrabajoDisponibles()
        {
            IAdministradorDeLineas adminLineas = _factoria.CrearAdministrador<IAdministradorDeLineas>();

            return adminLineas.ObtenerLineasDeTrabajoDisponibles();
        }

        public bool InsertarLineaDetrabajo(LineaDeTrabajoDTO lineaNueva)
        {
            IAdministradorDeLineas adminLineas = _factoria.CrearAdministrador<IAdministradorDeLineas>();

            return adminLineas.InsertarLineaDetrabajo(lineaNueva);
        }

        public bool ActualizarLineaDetrabajo(LineaDeTrabajoDTO actual)
        {
            IAdministradorDeLineas adminLineas = _factoria.CrearAdministrador<IAdministradorDeLineas>();

            return adminLineas.ActualizarLineaDetrabajo(actual);
        }

        public bool EliminarLineaDetrabajo(int lineaID)
        {
            IAdministradorDeLineas adminLineas = _factoria.CrearAdministrador<IAdministradorDeLineas>();

            return adminLineas.EliminarLineaDetrabajo(lineaID);
        }

        #endregion

        #region Request para Administrador De Usuarios

        public List<UsuarioDTO> ObtenerSupervisoresDeCalidadDisponibles()
        {
            IAdministradorUsuarios adminUsuarios = _factoria.CrearAdministrador<IAdministradorUsuarios>();

            return adminUsuarios.ObtenerSupervisoresDeCalidadDisponibles();

        }

        public bool InsertarUsuario(UsuarioDTO nuevoUsuario)
        {
            IAdministradorUsuarios adminUsuarios = _factoria.CrearAdministrador<IAdministradorUsuarios>();

            return adminUsuarios.InsertarUsuario(nuevoUsuario);
        }

        public bool EliminarUsuario(int usuarioId)
        {
            IAdministradorUsuarios adminUsuarios = _factoria.CrearAdministrador<IAdministradorUsuarios>();

            return adminUsuarios.EliminarUsuario(usuarioId);
        }

        public bool ActualizarUsuario(UsuarioDTO actualizacion)
        {
            IAdministradorUsuarios adminUsuarios = _factoria.CrearAdministrador<IAdministradorUsuarios>();

            return adminUsuarios.ActualizarUsuario(actualizacion);
        }

        #endregion

        #region Request para Administrador De Jornadas

        public JornadaLaboralDTO ObtenerJornada(int supervisorId, int opId)
        {
            IAdministradorJornadaLaboral adminJornadaLaboral = _factoria.CrearAdministrador<IAdministradorJornadaLaboral>();

            return adminJornadaLaboral.ObtenerJornada(supervisorId, opId);
        }

        public bool FinalizarJornada(int jornadaId)
        {
            IAdministradorJornadaLaboral adminJornadaLaboral = _factoria.CrearAdministrador<IAdministradorJornadaLaboral>();

            return adminJornadaLaboral.FinalizarJornada(jornadaId);
        }

        public bool InsertarIncidecia(IncidenciaDTO nuevaIncidencia)
        {
            IAdministradorJornadaLaboral adminJornadaLaboral = _factoria.CrearAdministrador<IAdministradorJornadaLaboral>();

            return adminJornadaLaboral.InsertarIncidecia(nuevaIncidencia);
        }

        public List<DefectoDTO> ObtenerDefectosDeReproceso()
        {
            IAdministradorJornadaLaboral adminJornadaLaboral = _factoria.CrearAdministrador<IAdministradorJornadaLaboral>();

            return adminJornadaLaboral.ObtenerDefectosReproceso();
        }

        public List<DefectoDTO> ObtenerDefectosDeObservados()
        {
            IAdministradorJornadaLaboral adminJornadaLaboral = _factoria.CrearAdministrador<IAdministradorJornadaLaboral>();

            return adminJornadaLaboral.ObtenerDefectosObservados();
        }

        public DefectoDTO SeleccionarDefecto(int defectoId)
        {
            IAdministradorJornadaLaboral adminJornadaLaboral = _factoria.CrearAdministrador<IAdministradorJornadaLaboral>();

            return adminJornadaLaboral.SeleccionarDefecto(defectoId);
        }



        #endregion

        #region Request para Administrador De OP

        public bool CrearOP(OrdenDeProduccionDTO op)
        {
            IAdministradorOP adminOP = _factoria.CrearAdministrador<IAdministradorOP>();

            return adminOP.InsertarOP(op);
        }

        public bool ActivarOP(int usuarioId, int opId)
        {
            IAdministradorOP adminOP = _factoria.CrearAdministrador<IAdministradorOP>();

            return adminOP.ActivarOrdenDeProduccion(usuarioId, opId);
        }

        public bool FinalizarOP(int usuarioId, int opId)
        {
            IAdministradorOP adminOP = _factoria.CrearAdministrador<IAdministradorOP>();

            return adminOP.FinalizarOrdenDeProduccion(usuarioId, opId);
        }

        public bool PausarOP(int usuarioId, int opId)
        {
            IAdministradorOP adminOP = _factoria.CrearAdministrador<IAdministradorOP>();

            return adminOP.PausarOrdenDeProduccion(usuarioId, opId);
        }

        public bool AsociarSupervisorDeCalidad(int usuarioId, int opId)
        {
            IAdministradorOP adminOP = _factoria.CrearAdministrador<IAdministradorOP>();

            return adminOP.AsociarSupervisorCalidad(usuarioId, opId);
        }

        public bool DesasociarSupervisorDeCalidad(int usuarioId, int opId)
        {
            IAdministradorOP adminOP = _factoria.CrearAdministrador<IAdministradorOP>();

            return adminOP.DesasociarSupervisorCalidad(usuarioId, opId);
        }

        public SemaforoDTO ConsultarSemaforoObservados(int usuarioId, int opId)
        {
            IAdministradorOP adminOP = _factoria.CrearAdministrador<IAdministradorOP>();

            return adminOP.ConsultarSemaforoObservados(usuarioId, opId);
        }

        public SemaforoDTO ConsultarSemaforoReproceso(int usuarioId, int opId)
        {
            IAdministradorOP adminOP = _factoria.CrearAdministrador<IAdministradorOP>();

            return adminOP.ConsultarSemaforoReproceso(usuarioId, opId);
        }

        public bool ReinicarSemaforoReproceso(int supervisorId, int ordenDeProduccionId)
        {
            IAdministradorOP adminOP = _factoria.CrearAdministrador<IAdministradorOP>();

            return adminOP.ReinicarSemaforoReproceso(supervisorId, ordenDeProduccionId);
        }

        public bool ReinicarSemaforoObservados(int supervisorId, int ordenDeProduccionId)
        {
            IAdministradorOP adminOP = _factoria.CrearAdministrador<IAdministradorOP>();

            return adminOP.ReinicarSemaforoObservados(supervisorId, ordenDeProduccionId);
        }

        public bool SupervisorPuedeCrearOP(int usuarioId)
        {
            IAdministradorOP adminOP = _factoria.CrearAdministrador<IAdministradorOP>();

            return adminOP.SupervisorPuedeCrearOP(usuarioId);
        }

        public OrdenDeProduccionDTO BuscarOPActualSupervisorDeCalidad(int supervisorId)
        {
            IAdministradorOP adminOP = _factoria.CrearAdministrador<IAdministradorOP>();

            return adminOP.ObtenerOPActualSupervisorDeCalidad(supervisorId);
        }


        #endregion



    }
}
