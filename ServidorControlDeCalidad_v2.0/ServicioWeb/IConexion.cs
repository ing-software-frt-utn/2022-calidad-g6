using Aplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract(SessionMode = SessionMode.NotAllowed)]
    public interface IConexion
    {
        //Foult contract el metodo puede comunicar excepciones t aplication service error
        #region Contratos de Manejo de Usuarios

        [OperationContract]
        UsuarioDTO LogearUsuario(string cuenta, string password);

        [OperationContract]
        List<UsuarioDTO> ObtenerSupervisoresDeCalidadDisponibles();

        [OperationContract]

        bool InsertarUsuario(UsuarioDTO nuevoUsuario);

        bool EliminarUsuario(int usuarioId);

        bool ActualizarUsuario(UsuarioDTO actualizacion);

        #endregion

        #region Contratos de Manejo de Colores

        [OperationContract]
        bool EliminarColor(int colorId);

        [OperationContract]
        bool InsertarColor(ColorDTO nuevoColor);

        [OperationContract]
        bool ActualizarColor(ColorDTO actualizacion);

        [OperationContract]
        List<ColorDTO> ObtenerColoresActivos();

        [OperationContract]
        List<ColorDTO> BuscarColoresPorCodigo(string codigo);

        [OperationContract]
        List<ColorDTO> BuscarColoresPorDescripcion(string cadena);


        #endregion

        #region Contratos de Manejo de Modelos

        [OperationContract]
        List<ModeloDTO> ObtenerModelosActivos();

        [OperationContract]
        List<ModeloDTO> BuscarModelosPorSKU(string codigo);

        [OperationContract]
        List<ModeloDTO> BuscarModelosPorDescripcion(string cadena);

        [OperationContract]
        bool EliminarModelo(int modeloID);

        [OperationContract]
        bool InsertarModelo(ModeloDTO modelo);

        [OperationContract]
        bool ActualizarModelo(ModeloDTO modelo);

        #endregion

        #region Contratos de Manejo de OP

        [OperationContract]
        bool CrearOP(OrdenDeProduccionDTO op);

        [OperationContract]
        bool ActivarOP(int usuarioId, int opId);

        [OperationContract]
        bool FinalizarOP(int usuarioId, int opId);

        [OperationContract]
        bool PausarOP(int usuarioId, int opId);

        [OperationContract]
        bool AsociarSupervisorDeCalidad(int usuarioId, int opId);

        [OperationContract]
        bool DesasociarSupervisorDeCalidad(int usuarioId, int opId);

        bool SupervisorPuedeCrearOP(int usuarioId);

        [OperationContract]
        OrdenDeProduccionDTO BuscarOPActualSupervisorDeCalidad(int supervisorId);
        #endregion

        #region Contratos de Manejo de Lineas de Trabajo

        [OperationContract]
        List<LineaDeTrabajoDTO> ObtenerLineasDeTrabajo();

        [OperationContract]
        List<LineaDeTrabajoDTO> ObtenerLineasDeTrabajoDisponibles();

        [OperationContract]
        bool InsertarLineaDetrabajo(LineaDeTrabajoDTO lineaNueva);

        [OperationContract]
        bool ActualizarLineaDetrabajo(LineaDeTrabajoDTO actual);

        [OperationContract]
        bool EliminarLineaDetrabajo(int lineaID);

        #endregion

        #region Contratos de Manejo de Jornadas

        [OperationContract]
        JornadaLaboralDTO ObtenerJornada(int supervisorId, int opId);

        [OperationContract]
        bool FinalizarJornada(int jornadaId);

        #endregion

        #region Contratos de Manejos de Semaforos

        SemaforoDTO ConsultarSemaforoObservados(int usuarioId, int opId);

        SemaforoDTO ConsultarSemaforoReproceso(int usuarioId, int opId);

        bool ReinicarSemaforoReproceso(int supervisorId, int ordenDeProduccionId);
        bool ReinicarSemaforoObservados(int supervisorId, int ordenDeProduccionId);

        #endregion

        #region Contratos de manejo de Incidencias

        [OperationContract]
        bool InsertarIncidecia(IncidenciaDTO nuevaIncidencia);

        #endregion

        #region Contratos de manejo de Defectos

        [OperationContract]
        List<DefectoDTO> ObtenerDefectosDeReproceso();


        [OperationContract]
        List<DefectoDTO> ObtenerDefectosDeObservados();


        [OperationContract]
        DefectoDTO SeleccionarDefecto(int defectoId);


        #endregion


        // TODO: agregue aquí sus operaciones de servicio
    }


}
