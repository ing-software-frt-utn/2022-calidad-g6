using ConexionWeb.ConexionWebService;
using Presentacion.IVistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.IPresentadores
{
    public interface IPresentadorGestionarModelos
    {
        List<ModeloDTO> ObtenerModelos();

        void EstablecerReferenciaVistaGestion(IVistaGestionarModelos vista);
        void EstablecerReferenciaVistaNuevo(IVistaNuevoModelo vista);
        void EstablecerReferenciaVistaModificar(IVistaModificarModelo vista);
        void EstablecerReferenciaVistaEliminar(IVistaEliminarModelo vista);
        #region Parte Tomás
        void EstablecerMetodoBusqueda(bool eleccionSeleccion);
        List<ModeloDTO> BuscarModelos(string busqueda);
        #endregion
        #region Parte Franco

        void CrearNuevoModelo(string sku, string denominacion, int limInfRep, int limSupRep, int limInfObs, int limSupObs);

        #endregion
        void GuardarModificacionModelo(int id, string denominacion, string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado);
        bool ComprobacionGeneralParaGuardarCambiosEnModelo(string denominacion, string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado);

        bool ComprobarExistenciaDeModificacionesEnCampos(string denominacion, string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado);

        // Opción 1, para modificar modelo
        bool ComprobarSiAlgunCampoEstaVacio(string denominacion, string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado);
        // Opción 2, para crear modelo
        bool ComprobarSiAlgunCampoEstaVacio(string sku, string denominacion, string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado);


        bool ComprobarQueLosLimitesSeanEnteros(string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado);

        bool ComprobarLimiteInferiorMenorASuperior(string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado);
        void SetearValoresInicialesModeloSeleccionado(string denominacion, string limiteInferiorReproceso, string limiteInferiorObservado, string limiteSuperiorReproceso, string limiteSuperiorObservado);

        //void CargarTablaModelos(List<ModeloDTO> modelos);

        void EliminarModelo(int modeloId);

        void SetearMetodoDeBusqueda(bool buscarPorDescripcion);
    }
}
