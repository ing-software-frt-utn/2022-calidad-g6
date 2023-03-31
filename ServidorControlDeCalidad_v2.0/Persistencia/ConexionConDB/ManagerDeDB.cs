using Dominio.Entidades;
using Dominio.Enumeraciones;
using Dominio.Interfaces_DB;
using Persistencia.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.ConexionConDB
{
    public class ManagerDeDB : IManagerDeDB
    {

        private ContextoControlCalidad _contexto = new ContextoControlCalidad();

        public ManagerDeDB()
        {

        }


        #region Manejo de Enumeraciones

        #region Obtener

        public List<CategoriaDefecto> ObtenerCategoriasDefecto()
        {
            try
            {
                var aux = from a in _contexto.CategoriasDefecto orderby a.CategoriaDefectoId ascending select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<ClaseIncidencia> ObtenerClasesIncidencia()
        {
            try
            {
                var aux = from a in _contexto.ClasesIncidencia orderby a.ClaseIncidenciaId ascending select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<ClaseUsuario> ObtenerClasesDeUsuario()
        {
            try
            {
                var aux = from a in _contexto.ClasesUsuario orderby a.ClaseUsuarioId ascending select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<EstadoOP> ObtenerEtadosOP()
        {
            try
            {
                var aux = from a in _contexto.EstadosOP orderby a.EstadoOPId ascending select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<Pie> ObtenerPies()
        {
            try
            {
                var aux = from a in _contexto.Pies orderby a.PieId ascending select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<EstadoDeUso> ObtenerEstadosDeUso()
        {
            try
            {
                var aux = from a in _contexto.EstadosDeUso orderby a.EstadoDeUsoId ascending select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<EstadoDeLinea> ObtenerEstadosDeLinea()
        {
            try
            {
                var aux = from a in _contexto.EstadosDeLinea orderby a.EstadoDeLineaId ascending select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<EstadoSemaforo> ObtenerEstadosSemaforo()
        {
            try
            {
                var aux = from a in _contexto.EstadosSemaforo orderby a.EstadoSemaforoId ascending select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }


        #endregion

        #region Establecer

        public bool EstablecerCategoriasDefecto(List<CategoriaDefecto> categorias)
        {
            try
            {

                _contexto.CategoriasDefecto.AddRange(categorias);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool EstablecerClasesIncidencia(List<ClaseIncidencia> clases)
        {
            try
            {

                _contexto.ClasesIncidencia.AddRange(clases);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool EstablecerClasesDeUsuario(List<ClaseUsuario> clases)
        {
            try
            {

                _contexto.ClasesUsuario.AddRange(clases);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool EstablecerEtadosOP(List<EstadoOP> estados)
        {
            try
            {

                _contexto.EstadosOP.AddRange(estados);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool EstablecerPies(List<Pie> pies)
        {
            try
            {

                _contexto.Pies.AddRange(pies);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;

        }

        public bool EstablecerEstadosDeUso(List<EstadoDeUso> estados)
        {
            try
            {

                _contexto.EstadosDeUso.AddRange(estados);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool EstablecerEstadosDeLinea(List<EstadoDeLinea> estados)
        {
            try
            {

                _contexto.EstadosDeLinea.AddRange(estados);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool EstablecerEstadosSemaforo(List<EstadoSemaforo> estados)
        {
            try
            {

                _contexto.EstadosSemaforo.AddRange(estados);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        #endregion

        #region Seleccionar


        public CategoriaDefecto SeleccionarCategoriaDefecto(int id)
        {
            try
            {
                var aux = _contexto.CategoriasDefecto.Find(id);
                return aux;
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public ClaseIncidencia SeleccionarClaseIncidencia(int id)
        {
            try
            {
                var aux = _contexto.ClasesIncidencia.Find(id);
                return aux;
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public ClaseUsuario SeleccionarClaseDeUsuario(int id)
        {
            try
            {
                var aux = _contexto.ClasesUsuario.Find(id);
                return aux;
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public EstadoOP SeleccionarEtadoOP(int id)
        {
            try
            {
                var aux = _contexto.EstadosOP.Find(id);
                return aux;
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public Pie SeleccionarPie(int id)
        {
            try
            {
                var aux = _contexto.Pies.Find(id);
                return aux;
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public EstadoDeUso SeleccionarEstadoDeUso(int id)
        {
            try
            {
                var aux = _contexto.EstadosDeUso.Find(id);
                return aux;
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }



        public EstadoDeLinea SeleccionarEstadoDeLinea(int id)
        {
            try
            {
                var aux = _contexto.EstadosDeLinea.Find(id);
                return aux;
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public EstadoSemaforo SeleccionarEstadoSemaforo(int id)
        {
            try
            {
                var aux = _contexto.EstadosSemaforo.Find(id);
                return aux;
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }


        #endregion

        #endregion

        #region Manejo de Usuarios
        public int ObtenerCuentasDeUsuarios()
        {
            try
            {
                var aux = from a in _contexto.Usuarios select a ;
                return aux.Count();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return -99;
        }

        public bool EstablecerUsuariosIniciales(List<Usuario> usuarios)
        {
            try
            {

                _contexto.Usuarios.AddRange(usuarios);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool InsertarUsuario(Usuario usuario)
        {
            try
            {
                if (!_contexto.Usuarios.Any(p => p.Dni == usuario.Dni))
                {
                    _contexto.Usuarios.Add(usuario);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public Usuario LogearUsuario(string cuenta, string password)
        {
            try
            {
                List<Usuario> aux = _contexto.Usuarios.SqlQuery($"SELECT * FROM [ControlCalidadDb].[dbo].[Usuarios] WHERE [CuentaDeUsuario] = '{cuenta}' AND  [Password] = '{password}'").ToList();
                
                if(aux != null)
                {
                    if(aux.Count > 0)
                    {
                        return aux[0];
                    }
                }
                
                
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<Usuario> ObtenerSupervisoresDeCalidadDisponibles()
        {
            try
            {
                List<Usuario> aux = _contexto.Usuarios.SqlQuery(
                    $"SELECT * " +
                        $"FROM [ControlCalidadDb].[dbo].[Usuarios] " +
                            $"WHERE [ClaseUsuarioId] = 3 AND [UsuarioId] NOT IN " +
                                $"( " +
                                    $"SELECT DISTINCT [UsuarioId] " +
                                        $"FROM [ControlCalidadDb].[dbo].[Incidencias] " +
                                            $"WHERE [JornadaLaboralId] IN " +
                                                $"( " +
                                                    $"SELECT DISTINCT [JornadaLaboralId] " +
                                                        $"FROM [ControlCalidadDb].[dbo].[JornadasLaborales] " +
                                                            $"WHERE [OrdenDeProduccionId] IN " +
                                                                $"( " +
                                                                    $"SELECT [OrdenDeProduccionId] " +
                                                                        $"FROM [ControlCalidadDb].[dbo].[OrdenesDeProduccion] " +
                                                                            $"WHERE [EstadoOPId] != 3 " +
                                                                $") " +
                                                $") " +
                                  $")").ToList();

                return aux;


            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public Usuario SeleccionarUsuario(int id)
        {
            try
            {
                var aux = _contexto.Usuarios.Find(id);
                return aux;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public bool EditarUsuario(Usuario actualizacion)
        {
            try
            {
                Usuario aux = SeleccionarUsuario(actualizacion.UsuarioId);
                aux.Apellido = actualizacion.Apellido;
                aux.Nombre = actualizacion.Nombre;
                aux.Dni = actualizacion.Dni;
                aux.Email = actualizacion.Email;
                aux.CuentaDeUsuario = actualizacion.CuentaDeUsuario;
                aux.Password = actualizacion.Password;
                aux.Puesto = SeleccionarClaseDeUsuario(actualizacion.Puesto.ClaseUsuarioId);
                aux.ClaseUsuarioId = aux.Puesto.ClaseUsuarioId;                
                _contexto.SaveChanges();

                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool EliminarUsuario(int usuarioId)
        {
            try
            {
                Usuario aux = SeleccionarUsuario(usuarioId);
                _contexto.Usuarios.Remove(aux);
                _contexto.SaveChanges();

                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            try
            {
                var aux = from a in _contexto.Usuarios select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

                
            }
            return null;
        }



        #endregion

        #region Manejo De Turnos
        public int ObtenerCantidadDeTurnos()
        {
            try
            {
                var aux = from a in _contexto.Turnos select a;
                return aux.Count();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return -99;
        }

        public bool EstablecerTurnosIniciales(List<Turno> turnos)
        {
            try
            {

                _contexto.Turnos.AddRange(turnos);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public List<Turno> ObtenerTurnos()
        {
            try
            {
                var aux = from a in _contexto.Turnos select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }


        #endregion

        #region Manejo de Colores

        public List<Color> ObtenerColores()
        {
            try
            {
                var aux = from a in _contexto.Colores select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<Color> ObtenerColoresActivos()
        {
            try
            {
                var aux = from a in _contexto.Colores where a.Estado.EstadoDeUsoId == 1 select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public bool EstablecerColores(List<Color> colores)
        {
            try
            {

                _contexto.Colores.AddRange(colores);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }


        public bool InsertarColor(Color color)
        {
            try
            {
                if (!_contexto.Colores.Any( c => c.Codigo == color.Codigo))
                {
                    _contexto.Colores.Add(color);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool ActualizarColor(Color Color)
        {
            try
            {
                Color aux = _contexto.Colores.Find(Color.ColorId);
                if (aux != null)
                {
                    aux.Descripcion = Color.Descripcion;
                    _contexto.SaveChanges();
                    return true;
                }
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool EliminarColor(int colorId)
        {
            try
            {
                Color aux = _contexto.Colores.Find(colorId);
                if (aux != null)
                {
                    EstadoDeUso nuevoEstado = SeleccionarEstadoDeUso(2);
                    aux.EstadoDeUsoId = 2;
                    aux.Estado = nuevoEstado;
                    _contexto.SaveChanges();
                    return true;
                }
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public Color SeleccionarColor(int colorId)
        {
            try
            {
                var aux = _contexto.Colores.Find(colorId);
                return aux;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<Color> BuscarColorPorCodigo(string codigo)
        {
            try
            {
                List<Color> aux = _contexto.Colores.SqlQuery($"SELECT * FROM [ControlCalidadDb].[dbo].[Colores] WHERE [Codigo] LIKE '{codigo}%'").ToList();
                return aux;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<Color> BuscarColorPorNombre(string nombre)
        {
            try
            {
                List<Color> aux = _contexto.Colores.SqlQuery($"SELECT * FROM [ControlCalidadDb].[dbo].[Colores] WHERE [Descripcion] LIKE '{nombre}%'").ToList();
                return aux;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }


        #endregion

        #region Manejo de Modelos

        public bool EstablecerModelos(List<Modelo> modelos)
        {
            try
            {

                _contexto.Modelos.AddRange(modelos);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public List<Modelo> ObtenerModelosActivos()
        {
            try
            {
                var aux = from a in _contexto.Modelos where a.EstadoDeUsoId == 1 select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public bool InsertarModelo(Modelo modelo)
        {
            try
            {
                if (!_contexto.Modelos.Any(m => m.SKU == modelo.SKU))
                {
                    _contexto.Modelos.Add(modelo);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool ActualizarModelo(Modelo actual)
        {
            try
            {
                Modelo aux = _contexto.Modelos.Find(actual.ModeloId);
                if (aux != null)
                {
                    aux.Descripcion = actual.Descripcion;
                    aux.LimiteInferiorObservado = actual.LimiteInferiorObservado;
                    aux.LimiteSuperiorObservado = actual.LimiteSuperiorObservado;
                    aux.LimiteInferiorReproceso = actual.LimiteInferiorReproceso;
                    aux.LimiteSuperiorReproceso = actual.LimiteSuperiorReproceso;
                    _contexto.SaveChanges();
                    return true;
                }
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool EliminarModelo(int modeloId)
        {
            try
            {
                Modelo aux = _contexto.Modelos.Find(modeloId);
                if (aux != null)
                {
                    EstadoDeUso nuevoEstado = SeleccionarEstadoDeUso(2);
                    aux.EstadoDeUsoId = 2;
                    aux.Estado = nuevoEstado;
                    _contexto.SaveChanges();
                    return true;
                }
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public Modelo SeleccionarModelo(int modeloId)
        {
            try
            {
                var aux = _contexto.Modelos.Find(modeloId);
                return aux;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<Modelo> BuscarModelosPorSKU(string sku)
        {
            try
            {
                List<Modelo> aux = _contexto.Modelos.SqlQuery($"SELECT * FROM [ControlCalidadDb].[dbo].[Modelos] WHERE [SKU] LIKE '{sku}%'").ToList();
                return aux;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<Modelo> BuscarModelosPorDescripcion(string descripcion)
        {
            try
            {
                List<Modelo> aux = _contexto.Modelos.SqlQuery($"SELECT * FROM [ControlCalidadDb].[dbo].[Modelos] WHERE [Descripcion] LIKE '{descripcion}%'").ToList();
                return aux;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }




        #endregion

        #region Manejo de Ordenes de Produccion

        public bool EstablecerOrdenesDeProduccionIniciales(List<OrdenDeProduccion> ops)
        {
            try
            {

                _contexto.OrdenesDeProduccion.AddRange(ops);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public List<OrdenDeProduccion> ObtenerOrdenesDeProduccion()
        {
            try
            {
                var aux = from a in _contexto.OrdenesDeProduccion select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }


        public OrdenDeProduccion SeleccionarOrdenDeProduccion(int opId)
        {
            try
            {
                var aux = _contexto.OrdenesDeProduccion.Find(opId);
                return aux;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public bool InsertarOrdenDeProduccion(OrdenDeProduccion nuevaOp)
        {
            try
            {
                if (!_contexto.OrdenesDeProduccion.Any(o => o.NumeroOP == nuevaOp.NumeroOP))
                {
                    _contexto.OrdenesDeProduccion.Add(nuevaOp);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool ActualizarOrdenDeProduccion(OrdenDeProduccion actual)
        {
            try
            {
                _contexto.SaveChanges();
                return true;
                
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public OrdenDeProduccion SeleccionarOPActiva(int supervisorDeLineaId)
        {
            try
            {
                var aux = from a in _contexto.OrdenesDeProduccion where a.SupervisorId == supervisorDeLineaId && a.EstadoOPId != 3 orderby a.OrdenDeProduccionId descending select a ;
                if(aux.Count() == 1)
                {
                    return aux.ToList()[0];
                }                

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public OrdenDeProduccion SeleccionarOPActivaSupervisorDeCalidad(int supervisorDeCalidadId)
        {
            try
            {
                var aux = from a in _contexto.OrdenesDeProduccion where a.UsuarioId == supervisorDeCalidadId && a.EstadoOPId != 3 orderby a.OrdenDeProduccionId descending select a;
                if (aux.Count() == 1)
                {
                    return aux.ToList()[0];
                }

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }



        #endregion

        #region Manejo de Lineas De Trabajo

        public bool EstablecerLineas(List<LineaDeTrabajo> lineas)
        {
            try
            {

                _contexto.LineasDeTrabajo.AddRange(lineas);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public List<LineaDeTrabajo> ObtenerLineasDeTrabajo()
        {
            try
            {
                var aux = from a in _contexto.LineasDeTrabajo where a.EstadoDeUsoId == 1 select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<LineaDeTrabajo> ObtenerLineasDeTrabajoDisponibles()
        {
            
            try
            {
                //List<LineaDeTrabajo> aux = _contexto.LineasDeTrabajo.SqlQuery(
                //    "SELECT * " +
                //        $"FROM [ControlCalidadDb].[dbo].[LineasDeTrabajo] " +
                //            $"WHERE [NumeroDeLinea] NOT IN " +
                //            $"( " +
                //                $"SELECT [LineaDeTrabajoId] " +
                //                    $"FROM [ControlCalidadDb].[dbo].[OrdenesDeProduccion] " +
                //                        $"WHERE [EstadoOPId] != 3 " +
                //            $")").ToList();

                var aux = from a in _contexto.LineasDeTrabajo where a.EstadoDeLineaId == 1 select a;

                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public bool InsertarLineaDeTrabajo(LineaDeTrabajo linea)
        {
            try
            {
                if (!_contexto.LineasDeTrabajo.Any(L => L.NumeroDeLinea == linea.NumeroDeLinea))
                {
                    _contexto.LineasDeTrabajo.Add(linea);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool ActualizarLineaDeTrabajo(LineaDeTrabajo linea)
        {
            try
            {
                LineaDeTrabajo aux = _contexto.LineasDeTrabajo.Find(linea.LineaDeTrabajoId);
                if (aux != null)
                {
                    aux.NumeroDeLinea = linea.NumeroDeLinea;
                    EstadoDeLinea estadoNuevo = SeleccionarEstadoDeLinea(linea.EstadoDeLinea.EstadoDeLineaId);
                    aux.EstadoDeLinea = estadoNuevo;
                    aux.EstadoDeLineaId = estadoNuevo.EstadoDeLineaId;
                    aux.SemaforoObservados = linea.SemaforoObservados;
                    aux.SemaforoReproceso = linea.SemaforoReproceso;
                    _contexto.SaveChanges();
                    return true;
                }
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool EliminarLineaDeTrabajo(int lineaId)
        {
            try
            {
                LineaDeTrabajo aux = _contexto.LineasDeTrabajo.Find(lineaId);
                if (aux != null)
                {
                    EstadoDeUso nuevoEstado = SeleccionarEstadoDeUso(2);
                    aux.EstadoDeUsoId = 2;
                    aux.EstadoDeUso = nuevoEstado;
                    _contexto.SaveChanges();
                    return true;
                }
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public LineaDeTrabajo SeleccionarLinea(int lineaId)
        {
            try
            {
                var aux = _contexto.LineasDeTrabajo.Find(lineaId);
                return aux;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }



        #endregion

        #region Manejo de Jornadas Laborales

        public JornadaLaboral SeleccionarJornadaLaboral(int jornadaId)
        {
            try
            {
                var aux = _contexto.JornadasLaborales.Find(jornadaId);
                return aux;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }


        public JornadaLaboral RecuperarUltimaJornada(int supervisorId)
        {
            try
            {
                var aux = from a in _contexto.JornadasLaborales where a.SupervisorDeCalidad.UsuarioId == supervisorId orderby a.JornadaLaboralId descending select a ;
                return aux.ToList()[0];
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public bool InsertarNuevaJornada(JornadaLaboral nuevaJornada)
        {
            try
            {
                _contexto.JornadasLaborales.Add(nuevaJornada);
                _contexto.SaveChanges();
                return true; ;
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public bool FinalizarJornada(int jornadaId)
        {
            try
            {
                JornadaLaboral aux =(JornadaLaboral) from a in _contexto.JornadasLaborales where a.JornadaLaboralId == jornadaId select a;
                aux.HoraFin = DateTime.Now.Hour;
                _contexto.SaveChanges();
                return true;
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }


        #endregion

        #region Manejo de Defectos

        public bool EstablecerDefectosIniciales(List<Defecto> defectos)
        {
            try
            {

                _contexto.Defectos.AddRange(defectos);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public Defecto SeleccionarDefecto(int id)
        {
            try
            {
                var aux = _contexto.Defectos.Find(id);
                return aux;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<Defecto> ObtenerDefectosDeReproceso()
        {
            try
            {
                var aux = from a in _contexto.Defectos where a.CategoriaDefectoId == 1 select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public List<Defecto> ObtenerDefectosDeObservado()
        {
            try
            {
                var aux = from a in _contexto.Defectos where a.CategoriaDefectoId == 2 select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }


        #endregion

        #region Manejo de Incidencias

        public bool InsertarIncidecia(Incidencia nuevaIncidencia)
        {
            try
            {
                _contexto.Incidencias.Add(nuevaIncidencia);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }


        public bool EstablecerIncidencias(List<Incidencia> incidencias)
        {
            try
            {

                _contexto.Incidencias.AddRange(incidencias);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }


        public List<Incidencia> ObtenerIncidencias()
        {
            try
            {
                var aux = from a in _contexto.Incidencias select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public int ObtenerConteoActualDeDefecto(int jornadaId, int defectoId)
        {
            try
            {
                var aux = (from a in _contexto.Incidencias where a.JornadaLaboralId == jornadaId && a.DefectoId == defectoId select a.Valor).Sum();
                return aux;
            }
            catch (InvalidOperationException ioe)
            {

            }
            return -99;
        }

        public int ObtenerConteoActualDeParesDePrimera(int jornadaId)
        {
            try
            {
                var aux = (from a in _contexto.Incidencias where a.JornadaLaboralId == jornadaId && a.ClaseIncidenciaId == 1 select a.Valor).Sum();
                return aux;
            }
            catch (InvalidOperationException ioe)
            {

            }
            return -99;
        }

        #endregion

        #region Manejo de Semaforos


        public List<Semaforo> ObtenerSemaforos()
        {
            try
            {
                var aux = from a in _contexto.Semaforos orderby a.SemaforoId ascending select a;
                return aux.ToList();
            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public bool EstablecerSemaforos(List<Semaforo> semaforos)
        {
            try
            {

                _contexto.Semaforos.AddRange(semaforos);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public Semaforo SeleccionarSemaforo(int semaforoId)
        {
            try
            {
                var aux = _contexto.Semaforos.Find(semaforoId);
                return aux;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }

        public bool ActualizarSemaforo(Semaforo actualizacion)
        {
            try
            {
                Semaforo aux = _contexto.Semaforos.Find(actualizacion.SemaforoId);
                if (aux != null)
                {
                    aux.Estado = SeleccionarEstadoSemaforo(actualizacion.Estado.EstadoSemaforoId);
                    aux.Valor = actualizacion.Valor;
                    _contexto.SaveChanges();
                    return true;
                }
            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }




        #endregion

        #region Manejo de Alertas

        public bool InsertarAlerta(Alerta nuevaAlerta)
        {
            try
            {
                _contexto.Alertas.Add(nuevaAlerta);
                _contexto.SaveChanges();
                return true;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return false;
        }

        public Alerta SeleccionarAlerta(int alertaId)
        {
            try
            {
                var aux = _contexto.Alertas.Find(alertaId);
                return aux;

            }
            catch (InvalidOperationException ioe)
            {

            }
            return null;
        }


        #endregion

    }
}
