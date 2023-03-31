using ConexionWeb.ConexionWebService;
using Presentacion.IPresentadores;
using Presentacion.IVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vistas
{
    public partial class VistaInspeccionarCalzado : Form, IVistaInspeccionarCalzado
    {
        private IPresentadorInspeccionarCalzado _presentadorInspeccionarCalzado;
        public VistaInspeccionarCalzado(IPresentadorInspeccionarCalzado presentadorInspeccionarCalzado)
        {
            _presentadorInspeccionarCalzado = presentadorInspeccionarCalzado;
            InitializeComponent();
            _presentadorInspeccionarCalzado.EstablecerVista(this);
            _presentadorInspeccionarCalzado.CargarJornadaLaboral();
            _presentadorInspeccionarCalzado.ObtenerDatosCabecera();
            if (_presentadorInspeccionarCalzado.ComprobarHoraActualTurno(_presentadorInspeccionarCalzado.ObtenerHoraActual(), _presentadorInspeccionarCalzado.ObtenerHoraInicioTurnoActual(), _presentadorInspeccionarCalzado.ObtenerHoraFinTurnoActual()))
            {
                CargarAmbasTablasDeDefectos(_presentadorInspeccionarCalzado.ObtenerDefectosReproceso(), _presentadorInspeccionarCalzado.ObtenerDefectosObservado());
                _presentadorInspeccionarCalzado.InicializarHoraRegistroIncidencias();
                EstablecerHoraInicialInspeccion(_presentadorInspeccionarCalzado.ObtenerHoraSeleccionadaRegistroIncidencias().ToString());
                ParesPrimeraInicialesJornadaLaboral(_presentadorInspeccionarCalzado.InicializarContadorParesPrimeraJornada());
            }

        }
        #region Cargar tablas de defectos
        public void CargarAmbasTablasDeDefectos(List<DefectoDTO> defectosReproceso, List<DefectoDTO> defectosObservado)
        {
            CargarTablaDefectosReproceso(defectosReproceso);
            CargarTablaDefectosObservado(defectosObservado);
        }

        private void CargarTablaDefectosReproceso(List<DefectoDTO> defectos) // En este método se cargan los datos de cada modelo en cada una de las filas de la tabla.
        {
            defectosReprocesoDG.Rows.Clear();

            foreach (var item in defectos)
            {
                int contadorPieDerecho;
                int contadorPieIzquierdo;

                contadorPieIzquierdo = _presentadorInspeccionarCalzado.ContarDefectosDelTipoYPie(_presentadorInspeccionarCalzado.ObtenerIncidenciasJornadaActual(), item.DefectoId, 1);
                contadorPieDerecho = _presentadorInspeccionarCalzado.ContarDefectosDelTipoYPie(_presentadorInspeccionarCalzado.ObtenerIncidenciasJornadaActual(), item.DefectoId, 2);

                defectosReprocesoDG.Rows.Add(item.DefectoId, item.Descripcion, contadorPieIzquierdo, contadorPieDerecho);
            }
        }

        public void ActualizarCeldaDefecto(int indiceFila, int indiceColumna, int incrementoDecremento)
        {

        }

        private void CargarTablaDefectosObservado(List<DefectoDTO> defectos) // En este método se cargan los datos de cada modelo en cada una de las filas de la tabla.
        {
            defectosObservadoDG.Rows.Clear();

            foreach (var item in defectos)
            {
                int contadorPieDerecho;
                int contadorPieIzquierdo;

                contadorPieIzquierdo = _presentadorInspeccionarCalzado.ContarDefectosDelTipoYPie(_presentadorInspeccionarCalzado.ObtenerIncidenciasJornadaActual(), item.DefectoId, 1);
                contadorPieDerecho = _presentadorInspeccionarCalzado.ContarDefectosDelTipoYPie(_presentadorInspeccionarCalzado.ObtenerIncidenciasJornadaActual(), item.DefectoId, 2);

                defectosObservadoDG.Rows.Add(item.DefectoId, item.Descripcion, contadorPieIzquierdo, contadorPieDerecho);

            }
        }

        #endregion
        #region Manejo de horas de registro de incidencias

        public void EstablecerHoraInicialInspeccion(string horaInicial)
        {
            horaSeleccionadaLB.Text = horaInicial;
        }
        private void ActualizarHoraInspeccion()
        {
            horaSeleccionadaLB.Text = _presentadorInspeccionarCalzado.ObtenerHoraSeleccionadaRegistroIncidencias().ToString();
        }
        #endregion
        #region Establecer los valores de la cabecera de la vista

        public void ExhibirApellidoYNombreSupervisor(string apellidoYNombre)
        {
            supervisorCalidadLB.Text = apellidoYNombre;
        }

        public void ExhibirDatosOp(string numeroOp, string numeroLinea, string modelo, string color)
        {
            numeroOpLB.Text = numeroOp;
            lineaTrabajoLB.Text = numeroLinea;
            modeloLB.Text = modelo;
            colorLB.Text = color;
        }
        #endregion
        #region Inicializar incidencias
        public void ParesPrimeraInicialesJornadaLaboral(string cantidadInicial)
        {
            contadorParesPrimeraLB.Text = cantidadInicial;
        }
        #endregion
        #region Aumentar y disminuir hora de registro
        private void aumentarHoraBTN_Click(object sender, EventArgs e)
        {
            _presentadorInspeccionarCalzado.IncrementarHoraSeleccionadaRegistroIncidencias();
            ActualizarHoraInspeccion();
        }

        private void disminuirHoraBTN_Click(object sender, EventArgs e)
        {
            _presentadorInspeccionarCalzado.DecrementarHoraSeleccionadaRegistroIncidencias();
            ActualizarHoraInspeccion();
        }
        #endregion

        #region Registro de incidencias
        private void aumentarParesPrimeraBTN_Click(object sender, EventArgs e)
        {
            _presentadorInspeccionarCalzado.RegistrarIncidenciaParDePrimera(1);
            ActualizarParesPrimeraJornadaLaboral(_presentadorInspeccionarCalzado.ObtenerContadorParesDePrimeraActualizado());
        }

        private void disminuirParesPrimeraBTN_Click(object sender, EventArgs e)
        {
            _presentadorInspeccionarCalzado.RegistrarIncidenciaParDePrimera(-1);
            ActualizarParesPrimeraJornadaLaboral(_presentadorInspeccionarCalzado.ObtenerContadorParesDePrimeraActualizado());
        }

        private void ActualizarParesPrimeraJornadaLaboral(string cantidadActualizada)
        {
            contadorParesPrimeraLB.Text = cantidadActualizada;
        }

        private void defectosReprocesoDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 1 && e.RowIndex >= 0)
            {
                int valorCelda = int.Parse(defectosReprocesoDG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                _presentadorInspeccionarCalzado.RegistrarIncidenciaDefecto(decrementarDefectosRB.Checked, int.Parse(defectosReprocesoDG.Rows[e.RowIndex].Cells[0].Value.ToString()), e.ColumnIndex - 1, valorCelda);
                if (!decrementarDefectosRB.Checked || valorCelda >0)
                {
                    ActualizarCeldaDefectoReproceso(e.RowIndex, e.ColumnIndex, decrementarDefectosRB.Checked);
                }
            }
        }

        private void defectosObservadoDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 1 && e.RowIndex >= 0)
            {
                int valorCelda = int.Parse(defectosObservadoDG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                _presentadorInspeccionarCalzado.RegistrarIncidenciaDefecto(decrementarDefectosRB.Checked, int.Parse(defectosObservadoDG.Rows[e.RowIndex].Cells[0].Value.ToString()), e.ColumnIndex - 1, valorCelda);
                if (!decrementarDefectosRB.Checked || valorCelda > 0)
                {
                    ActualizarCeldaDefectoObservado(e.RowIndex, e.ColumnIndex, decrementarDefectosRB.Checked);
                }
            }
        }
        #endregion

        #region Actualizar celdas cuando registro un defecto
        private void ActualizarCeldaDefectoReproceso(int fila, int columna, bool incrementoODecremento)
        {
            int valorNuevo = -99;
            if (incrementoODecremento)
            {
                valorNuevo = int.Parse(defectosReprocesoDG.Rows[fila].Cells[columna].Value.ToString()) - 1;
            }
            if (!incrementoODecremento)
            {
                valorNuevo = int.Parse(defectosReprocesoDG.Rows[fila].Cells[columna].Value.ToString()) + 1;
            }
            defectosReprocesoDG.Rows[fila].Cells[columna].Value = valorNuevo.ToString();
        }
        
        private void ActualizarCeldaDefectoObservado(int fila, int columna, bool incrementoODecremento)
        {
            int valorNuevo = -99;
            if (incrementoODecremento)
            {
                valorNuevo = int.Parse(defectosObservadoDG.Rows[fila].Cells[columna].Value.ToString()) - 1;
            }
            if (!incrementoODecremento)
            {
                valorNuevo = int.Parse(defectosObservadoDG.Rows[fila].Cells[columna].Value.ToString()) + 1;
            }
            defectosObservadoDG.Rows[fila].Cells[columna].Value = valorNuevo.ToString();
        }
        #endregion

        #region Manejo del radio button
        bool decrementarDefectosRBPresionado;
        private void decrementarDefectosRB_CheckedChanged(object sender, EventArgs e)
        {
            decrementarDefectosRBPresionado = decrementarDefectosRB.Checked;
        }

        private void decrementarDefectosRB_Click(object sender, EventArgs e)
        {
            if (decrementarDefectosRB.Checked &&
                !decrementarDefectosRBPresionado)
            {
                decrementarDefectosRB.Checked = false;
            }
            else
            {
                decrementarDefectosRB.Checked = true;
                decrementarDefectosRBPresionado = false;
            }
        }
        #endregion

        private void horaActualBTN_Click(object sender, EventArgs e)
        {
            _presentadorInspeccionarCalzado.VolverAHoraRegistroIncidenciasActual();
            ActualizarHoraInspeccion();
        }
    }
}
