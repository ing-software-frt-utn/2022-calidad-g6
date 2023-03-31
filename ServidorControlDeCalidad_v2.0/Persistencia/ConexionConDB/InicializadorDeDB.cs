using Dominio.Entidades;
using Dominio.Enumeraciones;
using Dominio.Interfaces_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.ConexionConDB
{
    public class InicializadorDeDB : IInicializadorDeDB
    {
        private IManagerDeDB _dB;

        public InicializadorDeDB(IManagerDeDB dataBase)
        {
            _dB = dataBase;
            InsertarDatosIniciales();
        }

        public void InsertarDatosIniciales()
        {
            CargarEstadosDeUso();
            CargarEstadosDeLinea();
            CargarCategoriasDefecto();
            CargarClasesIncidencia();
            CargarClasesDeUsuario();
            CargarEstadosOP();
            CargarColores();
            CargarPies();
            CargarTurnos();
            CargarUsuarios();
            CargarModelos();
            CargarLineasDeTrabajo();
            CargarEstadosSemaforo();
            CargarSemaforos();
            CargarDefectos();
            CargarOrdenesDeProduccion();
            CargarJornadas();
            CargarIncidencias();
            ActualizarSemaforos();
        }

        private void CargarEstadosDeUso()
        {
            List<EstadoDeUso> estados = _dB.ObtenerEstadosDeUso();

            if (estados == null || estados.Count == 0)
            {
                estados = new List<EstadoDeUso>
                {
                    new EstadoDeUso{ EstadoDeUsoId = 1 , Descripcion = "ACTIVO"},
                    new EstadoDeUso{ EstadoDeUsoId = 2 , Descripcion = "DESCONTINUADO"}
                };
                _dB.EstablecerEstadosDeUso(estados);
            }
        }

        private void CargarEstadosDeLinea()
        {
            List<EstadoDeLinea> estados = _dB.ObtenerEstadosDeLinea();

            if (estados == null || estados.Count == 0)
            {
                estados = new List<EstadoDeLinea>
                {
                    new EstadoDeLinea{ EstadoDeLineaId = 1 , Descripcion = "DISPONIBLE"},
                    new EstadoDeLinea{ EstadoDeLineaId = 2 , Descripcion = "OCUPADA"}
                };
                _dB.EstablecerEstadosDeLinea(estados);
            }
        }

        private void CargarCategoriasDefecto()
        {
            List<CategoriaDefecto> categorias = _dB.ObtenerCategoriasDefecto();

            if(categorias == null || categorias.Count == 0)
            {
                categorias = new List<CategoriaDefecto>
                {
                    new CategoriaDefecto{ CategoriaDefectoId = 1 , Descripcion = "REPROCESO"},
                    new CategoriaDefecto{ CategoriaDefectoId = 2 , Descripcion = "OBSERVADO"}
                };
                _dB.EstablecerCategoriasDefecto(categorias);
            }
        }

        private void CargarClasesIncidencia()
        {
            List<ClaseIncidencia> clases = _dB.ObtenerClasesIncidencia();

            if (clases == null || clases.Count == 0)
            {
                clases = new List<ClaseIncidencia>
                {
                    new ClaseIncidencia{ ClaseIncidenciaId = 1 , Descripcion = "PRIMERA"},
                    new ClaseIncidencia{ ClaseIncidenciaId = 2 , Descripcion = "DEFECTO"}
                };
                _dB.EstablecerClasesIncidencia(clases);
                    
            }

        }

        private void CargarClasesDeUsuario()
        {
            List<ClaseUsuario> clases = _dB.ObtenerClasesDeUsuario();

            if (clases == null || clases.Count == 0)
            {
                clases = new List<ClaseUsuario>
                {
                    new ClaseUsuario{ ClaseUsuarioId = 1 , Descripcion = "Administrador"},
                    new ClaseUsuario{ ClaseUsuarioId = 2 , Descripcion = "Supervisor De Linea"},
                    new ClaseUsuario{ ClaseUsuarioId = 3 , Descripcion = "Supervisor De Calidad"}
                };
                _dB.EstablecerClasesDeUsuario(clases);

                    
            }

        }

        private void CargarEstadosOP()
        {
            List<EstadoOP> estados = _dB.ObtenerEtadosOP();

            if (estados == null || estados.Count == 0)
            {
                estados = new List<EstadoOP>
                {
                    new EstadoOP{ EstadoOPId = 1 , Descripcion = "ACTIVADA"},
                    new EstadoOP{ EstadoOPId = 2 , Descripcion = "PAUSADA"},
                    new EstadoOP{ EstadoOPId = 3 , Descripcion = "FINALIZADA"}
                };
                _dB.EstablecerEtadosOP(estados);
            }

        }

        private void CargarColores()
        {
            List<Color> colores = _dB.ObtenerColores();

            if (colores == null || colores.Count == 0)
            {
                EstadoDeUso estado = _dB.SeleccionarEstadoDeUso(1);

                    colores = new List<Color>
                {
                    new Color{ ColorId = 1 , Descripcion = "Rojo/Negro", Codigo = 111 , EstadoDeUsoId = 1, Estado = estado },
                    new Color{ ColorId = 2 , Descripcion = "Azul Relampago", Codigo = 222 , EstadoDeUsoId = 1, Estado = estado },
                    new Color{ ColorId = 3 , Descripcion = "Verde Primavera", Codigo = 333 , EstadoDeUsoId = 1, Estado = estado },
                    new Color{ ColorId = 4 , Descripcion = "Fucsia/Blanco", Codigo = 444 , EstadoDeUsoId = 1, Estado = estado },
                    new Color{ ColorId = 5 , Descripcion = "Amarillo Patito", Codigo = 555 , EstadoDeUsoId = 1, Estado = estado },
                    new Color{ ColorId = 6 , Descripcion = "Naranja/Gris", Codigo = 666 , EstadoDeUsoId = 1, Estado = estado },
                    new Color{ ColorId = 7 , Descripcion = "Tundra", Codigo = 777 , EstadoDeUsoId = 1, Estado = estado }
                };
                _dB.EstablecerColores(colores);
            }

        }


        private void CargarPies()
        {
            List<Pie> pies = _dB.ObtenerPies();

            if (pies == null || pies.Count == 0)
            {
                pies = new List<Pie>
                {
                    new Pie{ PieId = 1 , Descripcion = "IZQUIERDO"},
                    new Pie{ PieId = 2 , Descripcion = "DERECHO"}
                };
                _dB.EstablecerPies(pies);
            }

        }

        private void CargarUsuarios()
        {
            int cuentas = _dB.ObtenerCuentasDeUsuarios();
            if (cuentas <= 0)
            {
                List<ClaseUsuario> clases = _dB.ObtenerClasesDeUsuario().ToList();
                List<Usuario> usuarios = new List<Usuario>
                {
                    new Usuario{ UsuarioId = 1 , CuentaDeUsuario ="Ezequiel", Password = "51689" , Apellido = "Bazán García" , Nombre = "Claudio Ezequiel" , Dni = 7777777 , Email = "BazanGarciaCE@ControlDeCalidad.com", ClaseUsuarioId = 1, Puesto = clases.Find(x => x.ClaseUsuarioId == 1)  },
                    new Usuario{ UsuarioId = 2 , CuentaDeUsuario ="Tomas", Password = "50049" , Apellido = "Issolio" , Nombre = "Tomás" , Dni = 99999999 , Email = "IssolioT@ControlDeCalidad.com", ClaseUsuarioId = 2 , Puesto = clases.Find(x => x.ClaseUsuarioId == 2) },
                    new Usuario{ UsuarioId = 3 , CuentaDeUsuario ="Franco", Password = "39601" , Apellido = "Romano" , Nombre = "Franco Dario" , Dni = 88888888 , Email = "RomanoFD@ControlDeCalidad.com", ClaseUsuarioId = 3 , Puesto = clases.Find(x => x.ClaseUsuarioId == 3) }

                };
                _dB.EstablecerUsuariosIniciales(usuarios);
            }
        }

        private void CargarTurnos()
        {
            int cantidadDeTurnos = _dB.ObtenerCantidadDeTurnos();

            if (cantidadDeTurnos <= 0)
            {
                List<Turno> turnos = new List<Turno>
                {
                    new Turno{ TurnoId = 1, Descripcion = "Mañana", HoraInicio = 6 , HoraFin = 12},
                    new Turno{ TurnoId = 1, Descripcion = "Tarde", HoraInicio = 12 , HoraFin = 18}

                };
                _dB.EstablecerTurnosIniciales(turnos);
            }
        }


        public void CargarModelos()
        {

            List<Modelo> modelos = _dB.ObtenerModelosActivos();

            if (modelos == null || modelos.Count == 0)
            {
                EstadoDeUso estado = _dB.SeleccionarEstadoDeUso(1);

                modelos = new List<Modelo>
                {
                    new Modelo{ ModeloId = 1 , Descripcion = "Signal", SKU = "00SG11RN" , LimiteInferiorObservado = 2 , LimiteSuperiorObservado = 6 , LimiteInferiorReproceso = 6 , LimiteSuperiorReproceso = 10 , EstadoDeUsoId = 1, Estado = estado },
                    new Modelo{ ModeloId = 2 , Descripcion = "Oceano", SKU = "20OC22AR" , LimiteInferiorObservado = 3 , LimiteSuperiorObservado = 5 , LimiteInferiorReproceso = 4 , LimiteSuperiorReproceso = 8 , EstadoDeUsoId = 1, Estado = estado },
                    new Modelo{ ModeloId = 3 , Descripcion = "Garden", SKU = "07GD33VP" , LimiteInferiorObservado = 4 , LimiteSuperiorObservado = 7 , LimiteInferiorReproceso = 5 , LimiteSuperiorReproceso = 9 , EstadoDeUsoId = 1, Estado = estado },
                    new Modelo{ ModeloId = 4 , Descripcion = "Ladie", SKU = "32LD44FB" , LimiteInferiorObservado = 2 , LimiteSuperiorObservado = 4 , LimiteInferiorReproceso = 3 , LimiteSuperiorReproceso = 7 , EstadoDeUsoId = 1, Estado = estado },
                    new Modelo{ ModeloId = 5 , Descripcion = "Sol", SKU = "21SL55AP" , LimiteInferiorObservado = 3 , LimiteSuperiorObservado = 6 , LimiteInferiorReproceso = 7 , LimiteSuperiorReproceso = 11 , EstadoDeUsoId = 1, Estado = estado },
                    new Modelo{ ModeloId = 6 , Descripcion = "Bird", SKU = "30BD66NG" , LimiteInferiorObservado = 4 , LimiteSuperiorObservado = 7 , LimiteInferiorReproceso = 5 , LimiteSuperiorReproceso = 10 , EstadoDeUsoId = 1, Estado = estado },
                    new Modelo{ ModeloId = 7 , Descripcion = "Antartica", SKU = "57AN77TU" , LimiteInferiorObservado = 2 , LimiteSuperiorObservado = 4 , LimiteInferiorReproceso = 3 , LimiteSuperiorReproceso = 8 , EstadoDeUsoId = 1, Estado = estado }
                };
                _dB.EstablecerModelos(modelos);
            }

        }

        private void CargarLineasDeTrabajo()
        {
            List<LineaDeTrabajo> lineas = _dB.ObtenerLineasDeTrabajo();

            if (lineas == null || lineas.Count == 0)
            {
                EstadoDeUso nuevo = _dB.SeleccionarEstadoDeUso(1);
                EstadoDeLinea estadoDeLinea = _dB.SeleccionarEstadoDeLinea(1);

                lineas = new List<LineaDeTrabajo>
                {
                    new LineaDeTrabajo {LineaDeTrabajoId = 1 , NumeroDeLinea = 4 , EstadoDeUsoId = 1 , EstadoDeUso =  nuevo, EstadoDeLineaId = 1, EstadoDeLinea = estadoDeLinea},
                    new LineaDeTrabajo {LineaDeTrabajoId = 2 , NumeroDeLinea = 3 , EstadoDeUsoId = 1 , EstadoDeUso =  nuevo, EstadoDeLineaId = 1, EstadoDeLinea = estadoDeLinea},
                    new LineaDeTrabajo {LineaDeTrabajoId = 3 , NumeroDeLinea = 2 , EstadoDeUsoId = 1 , EstadoDeUso =  nuevo, EstadoDeLineaId = 1, EstadoDeLinea = estadoDeLinea},
                    new LineaDeTrabajo {LineaDeTrabajoId = 4 , NumeroDeLinea = 1 , EstadoDeUsoId = 1 , EstadoDeUso =  nuevo, EstadoDeLineaId = 1, EstadoDeLinea = estadoDeLinea}
                };

                _dB.EstablecerLineas(lineas);
            }

        }

        private void CargarEstadosSemaforo()
        {
            List<EstadoSemaforo> estados = _dB.ObtenerEstadosSemaforo();

            if (estados == null || estados.Count == 0)
            {
                estados = new List<EstadoSemaforo>
                {
                    new EstadoSemaforo{ EstadoSemaforoId = 1 , Descripcion = "VERDE"},
                    new EstadoSemaforo{ EstadoSemaforoId = 2 , Descripcion = "AMARILLO"},
                    new EstadoSemaforo{ EstadoSemaforoId = 3 , Descripcion = "ROJO"}

                };
                _dB.EstablecerEstadosSemaforo(estados);
            }
        }

        private void CargarSemaforos()
        {
            List<Semaforo> semaforos = _dB.ObtenerSemaforos();

            if (semaforos == null || semaforos.Count != 8)
            {
                List<LineaDeTrabajo> lineas = _dB.ObtenerLineasDeTrabajo();
                EstadoSemaforo estado = _dB.SeleccionarEstadoSemaforo(1);
                semaforos = new List<Semaforo>
                {
                    new Semaforo{ SemaforoId = 1, Valor = 0, Linea = lineas.Find(x => x.NumeroDeLinea == 1), LineaDeTrabajoId = lineas.Find(x => x.NumeroDeLinea == 1).LineaDeTrabajoId, Estado = estado },
                    new Semaforo{ SemaforoId = 2, Valor = 0, Linea = lineas.Find(x => x.NumeroDeLinea == 1), LineaDeTrabajoId = lineas.Find(x => x.NumeroDeLinea == 1).LineaDeTrabajoId, Estado = estado },
                    new Semaforo{ SemaforoId = 3, Valor = 0, Linea = lineas.Find(x => x.NumeroDeLinea == 2), LineaDeTrabajoId = lineas.Find(x => x.NumeroDeLinea == 2).LineaDeTrabajoId, Estado = estado },
                    new Semaforo{ SemaforoId = 4, Valor = 0, Linea = lineas.Find(x => x.NumeroDeLinea == 2), LineaDeTrabajoId = lineas.Find(x => x.NumeroDeLinea == 2).LineaDeTrabajoId, Estado = estado },
                    new Semaforo{ SemaforoId = 5, Valor = 0, Linea = lineas.Find(x => x.NumeroDeLinea == 3), LineaDeTrabajoId = lineas.Find(x => x.NumeroDeLinea == 3).LineaDeTrabajoId, Estado = estado },
                    new Semaforo{ SemaforoId = 6, Valor = 0, Linea = lineas.Find(x => x.NumeroDeLinea == 3), LineaDeTrabajoId = lineas.Find(x => x.NumeroDeLinea == 3).LineaDeTrabajoId, Estado = estado },
                    new Semaforo{ SemaforoId = 7, Valor = 0, Linea = lineas.Find(x => x.NumeroDeLinea == 4), LineaDeTrabajoId = lineas.Find(x => x.NumeroDeLinea == 4).LineaDeTrabajoId, Estado = estado },
                    new Semaforo{ SemaforoId = 8, Valor = 0, Linea = lineas.Find(x => x.NumeroDeLinea == 4), LineaDeTrabajoId = lineas.Find(x => x.NumeroDeLinea == 4).LineaDeTrabajoId, Estado = estado }


                };
                _dB.EstablecerSemaforos(semaforos);

                LineaDeTrabajo linea1 = _dB.SeleccionarLinea(lineas.Find(x => x.NumeroDeLinea == 1).LineaDeTrabajoId);
                LineaDeTrabajo linea2 = _dB.SeleccionarLinea(lineas.Find(x => x.NumeroDeLinea == 2).LineaDeTrabajoId);
                LineaDeTrabajo linea3 = _dB.SeleccionarLinea(lineas.Find(x => x.NumeroDeLinea == 3).LineaDeTrabajoId);
                LineaDeTrabajo linea4 = _dB.SeleccionarLinea(lineas.Find(x => x.NumeroDeLinea == 4).LineaDeTrabajoId);

                linea1.SemaforoReproceso = _dB.SeleccionarSemaforo(1);
                linea1.SemaforoObservados = _dB.SeleccionarSemaforo(2);
                _dB.ActualizarLineaDeTrabajo(linea1);

                linea2.SemaforoReproceso = _dB.SeleccionarSemaforo(3);
                linea2.SemaforoObservados = _dB.SeleccionarSemaforo(4);
                _dB.ActualizarLineaDeTrabajo(linea2);

                linea3.SemaforoReproceso = _dB.SeleccionarSemaforo(5);
                linea3.SemaforoObservados = _dB.SeleccionarSemaforo(6);
                _dB.ActualizarLineaDeTrabajo(linea3);

                linea4.SemaforoReproceso = _dB.SeleccionarSemaforo(7);
                linea4.SemaforoObservados = _dB.SeleccionarSemaforo(8);
                _dB.ActualizarLineaDeTrabajo(linea4);

            }
        }



        private void CargarDefectos()
        {
            List<Defecto> reproceso = _dB.ObtenerDefectosDeReproceso();

            if (reproceso == null || reproceso.Count == 0)
            {
                CategoriaDefecto categoria = _dB.SeleccionarCategoriaDefecto(1);
                reproceso = new List<Defecto>
                {
                    new Defecto{ DefectoId = 1 , Descripcion ="Suela Despegada" , CategoriaDefectoId = 1 , Categoria = categoria},
                    new Defecto{ DefectoId = 2 , Descripcion ="Empeine Sucio" , CategoriaDefectoId = 1 , Categoria = categoria},
                    new Defecto{ DefectoId = 3 , Descripcion ="Talón Sucio" , CategoriaDefectoId = 1 , Categoria = categoria},
                    new Defecto{ DefectoId = 4 , Descripcion ="Cordón Roto" , CategoriaDefectoId = 1 , Categoria = categoria},
                    new Defecto{ DefectoId = 5 , Descripcion ="Empeine Sucio" , CategoriaDefectoId = 1 , Categoria = categoria},
                    new Defecto{ DefectoId = 6 , Descripcion ="Puntera Descosida" , CategoriaDefectoId = 1 , Categoria = categoria},
                    new Defecto{ DefectoId = 7 , Descripcion ="Lengueta Suelta" , CategoriaDefectoId = 1 , Categoria = categoria},
                    new Defecto{ DefectoId = 8 , Descripcion ="Puntera Sucia" , CategoriaDefectoId = 1 , Categoria = categoria},
                    new Defecto{ DefectoId = 9 , Descripcion ="Cordon Faltante" , CategoriaDefectoId = 1 , Categoria = categoria},
                    new Defecto{ DefectoId = 10 , Descripcion ="Lengueta Sucia" , CategoriaDefectoId = 1 , Categoria = categoria}
                };
                _dB.EstablecerDefectosIniciales(reproceso);
            }


            List<Defecto> observados = _dB.ObtenerDefectosDeObservado();

            if (observados == null || observados.Count == 0)
            { 
                CategoriaDefecto categoria = _dB.SeleccionarCategoriaDefecto(2);
                 observados = new List<Defecto>
                {
                    new Defecto{ DefectoId = 1 , Descripcion ="Puntera Rota" , CategoriaDefectoId = 2 , Categoria = categoria},
                    new Defecto{ DefectoId = 2 , Descripcion ="Talón Rasgado" , CategoriaDefectoId = 2 , Categoria = categoria},
                    new Defecto{ DefectoId = 3 , Descripcion ="Empeine Rasgado" , CategoriaDefectoId = 2 , Categoria = categoria},
                    new Defecto{ DefectoId = 4 , Descripcion ="Suela Equivocada" , CategoriaDefectoId = 2 , Categoria = categoria},
                    new Defecto{ DefectoId = 5 , Descripcion ="Lengueta Equivocada" , CategoriaDefectoId = 2 , Categoria = categoria},
                    new Defecto{ DefectoId = 6 , Descripcion ="Talon Manchado" , CategoriaDefectoId = 2 , Categoria = categoria},
                    new Defecto{ DefectoId = 7 , Descripcion ="Empeine Manchado" , CategoriaDefectoId = 2 , Categoria = categoria},
                    new Defecto{ DefectoId = 8 , Descripcion ="Suela Cuarteada" , CategoriaDefectoId = 2 , Categoria = categoria},
                    new Defecto{ DefectoId = 9 , Descripcion ="Lengueta Manchada" , CategoriaDefectoId = 2 , Categoria = categoria},
                    new Defecto{ DefectoId = 10 , Descripcion ="Puntera Manchada" , CategoriaDefectoId = 2 , Categoria = categoria}
                };
                _dB.EstablecerDefectosIniciales(observados);
            }
        }

        private void CargarOrdenesDeProduccion()
        {
            List<OrdenDeProduccion> ops = _dB.ObtenerOrdenesDeProduccion();

            Usuario supervisorDeLinea = _dB.SeleccionarUsuario(2);
            Usuario supervisorDeCalidad = _dB.SeleccionarUsuario(3);
            EstadoOP estadoOP = _dB.SeleccionarEtadoOP(2);
            Modelo modelo = _dB.SeleccionarModelo(4);
            LineaDeTrabajo linea = _dB.SeleccionarLinea(2);
            Color color = _dB.SeleccionarColor(3);

            if (ops == null || ops.Count <= 0)
            {
                
                linea.EstadoDeLinea = _dB.SeleccionarEstadoDeLinea(2);
                linea.EstadoDeLineaId = 2;
                _dB.ActualizarLineaDeTrabajo(linea);
                List<OrdenDeProduccion> ordenes = new List<OrdenDeProduccion>
                {
                    new OrdenDeProduccion{ OrdenDeProduccionId = 1, NumeroOP = 155482, SupervisorDeLinea = supervisorDeLinea, SupervisorId = 2, SupervisorDeCalidad = supervisorDeCalidad, UsuarioId = 3, Estado = estadoOP, EstadoOPId = 2, ModeloControlado = modelo, ModeloId = modelo.ModeloId, ColorModelo = color, ColorId = color.ColorId, FechaInicio = DateTime.Now, NumeroDeLinea = linea , LineaDeTrabajoId = linea.LineaDeTrabajoId, FechaFin = new DateTime(1900,1,1,7,0,0)}

                };
                _dB.EstablecerOrdenesDeProduccionIniciales(ordenes);
                
            }
            
        }

        private void CargarJornadas()
        {
            List<OrdenDeProduccion> ops = _dB.ObtenerOrdenesDeProduccion();
            Usuario supervisorDeCalidad = _dB.SeleccionarUsuario(3);
            if (ops.ElementAt(0).JornadasLaborales == null || ops.ElementAt(0).JornadasLaborales.Count <= 0)
            {

                List<Turno> turnos = _dB.ObtenerTurnos();
                List<JornadaLaboral> jornadas0 = new List<JornadaLaboral>();
                int id = 1;
                OrdenDeProduccion op = _dB.SeleccionarOrdenDeProduccion(1);
                foreach (var item in turnos)
                {
                    JornadaLaboral temp = new JornadaLaboral();
                    temp.JornadaLaboralId = id;
                    temp.Dueno = op;
                    temp.DuenoId = 1;
                    temp.Fecha = DateTime.Now;
                    temp.HoraInicio = item.HoraInicio;
                    temp.HoraFin = item.HoraFin;
                    temp.TurnoJornada = item;
                    temp.TurnoId = item.TurnoId;
                    temp.SupervisorDeCalidad = supervisorDeCalidad;
                    temp.UsuarioId = supervisorDeCalidad.UsuarioId;
                    jornadas0.Add(temp);
                    id++;
                }
                op.JornadasLaborales = jornadas0;
                _dB.ActualizarOrdenDeProduccion(op);
                
            }
        }

        private void CargarIncidencias()
        {
            List<JornadaLaboral> jornadas = _dB.SeleccionarOrdenDeProduccion(1).JornadasLaborales;
            Usuario supervisorDeCalidad = _dB.SeleccionarUsuario(3);
            if (jornadas.ElementAt(0).Incidencias == null || jornadas.ElementAt(0).Incidencias.Count <= 0)
            {
                List<Pie> pies = _dB.ObtenerPies();
                List<ClaseIncidencia> tiposIncidencia = _dB.ObtenerClasesIncidencia();
                List<Defecto> defectosObservado = _dB.ObtenerDefectosDeObservado();
                List<Defecto> defectosReproceso = _dB.ObtenerDefectosDeReproceso();
                List<Incidencia> incidencias1 = new List<Incidencia>
                {
                    new Incidencia{ IncidenciaId = 1, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 1, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosObservado.ElementAt(0) , DefectoId = defectosObservado.ElementAt(0).DefectoId , EncontradoEnPie = pies.ElementAt(0) , PieId = 1 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 2, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 1, Valor = -1, Hora = DateTime.Now , DefectoEncontrado = defectosObservado.ElementAt(0) , DefectoId = defectosObservado.ElementAt(0).DefectoId , EncontradoEnPie = pies.ElementAt(0) , PieId = 1 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 3, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 1, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosObservado.ElementAt(1) , DefectoId = defectosObservado.ElementAt(1).DefectoId , EncontradoEnPie = pies.ElementAt(1) , PieId = 2 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 4, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 1, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosObservado.ElementAt(2) , DefectoId = defectosObservado.ElementAt(2).DefectoId , EncontradoEnPie = pies.ElementAt(0) , PieId = 1 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 5, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 1, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosObservado.ElementAt(1) , DefectoId = defectosObservado.ElementAt(1).DefectoId , EncontradoEnPie = pies.ElementAt(1) , PieId = 2 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 6, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 1, Valor = -1, Hora = DateTime.Now , DefectoEncontrado = defectosObservado.ElementAt(1) , DefectoId = defectosObservado.ElementAt(1).DefectoId , EncontradoEnPie = pies.ElementAt(1) , PieId = 2 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 7, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 1, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosObservado.ElementAt(3) , DefectoId = defectosObservado.ElementAt(3).DefectoId , EncontradoEnPie = pies.ElementAt(0) , PieId = 1 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 8, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 1, Valor = 1, Hora = DateTime.Now , TipoIncidencia = tiposIncidencia.ElementAt(0), ClaseIncidenciaId = 1 },
                    new Incidencia{ IncidenciaId = 9, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 1, Valor = 1, Hora = DateTime.Now , TipoIncidencia = tiposIncidencia.ElementAt(0), ClaseIncidenciaId = 1 },
                    new Incidencia{ IncidenciaId = 10, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 1, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosObservado.ElementAt(3) , DefectoId = defectosObservado.ElementAt(3).DefectoId , EncontradoEnPie = pies.ElementAt(1) , PieId = 2 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                };
                _dB.EstablecerIncidencias(incidencias1);

                List<Incidencia> incidencias2 = new List<Incidencia>
                {
                    new Incidencia{ IncidenciaId = 11, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 2, Valor = 1, Hora = DateTime.Now , TipoIncidencia = tiposIncidencia.ElementAt(0), ClaseIncidenciaId = 1 },
                    new Incidencia{ IncidenciaId = 12, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 2, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosObservado.ElementAt(0) , DefectoId = defectosObservado.ElementAt(0).DefectoId , EncontradoEnPie = pies.ElementAt(0) , PieId = 1 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 13, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 2, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosObservado.ElementAt(1) , DefectoId = defectosObservado.ElementAt(1).DefectoId , EncontradoEnPie = pies.ElementAt(1) , PieId = 2 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 14, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 2, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosObservado.ElementAt(2) , DefectoId = defectosObservado.ElementAt(2).DefectoId , EncontradoEnPie = pies.ElementAt(0) , PieId = 1 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 15, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 2, Valor = 1, Hora = DateTime.Now , TipoIncidencia = tiposIncidencia.ElementAt(0), ClaseIncidenciaId = 1 },
                    new Incidencia{ IncidenciaId = 16, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 2, Valor = -1, Hora = DateTime.Now ,TipoIncidencia = tiposIncidencia.ElementAt(0), ClaseIncidenciaId = 1 },
                    new Incidencia{ IncidenciaId = 17, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 2, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosObservado.ElementAt(3) , DefectoId = defectosObservado.ElementAt(3).DefectoId , EncontradoEnPie = pies.ElementAt(0) , PieId = 1 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 18, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 2, Valor = 1, Hora = DateTime.Now , TipoIncidencia = tiposIncidencia.ElementAt(0), ClaseIncidenciaId = 1 },
                    new Incidencia{ IncidenciaId = 19, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 2, Valor = 1, Hora = DateTime.Now , TipoIncidencia = tiposIncidencia.ElementAt(0), ClaseIncidenciaId = 1 },
                    new Incidencia{ IncidenciaId = 20, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 2, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosObservado.ElementAt(3) , DefectoId = defectosObservado.ElementAt(3).DefectoId , EncontradoEnPie = pies.ElementAt(1) , PieId = 2 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                };
                _dB.EstablecerIncidencias(incidencias2);

                List<Incidencia> incidencias3 = new List<Incidencia>
                {
                    new Incidencia{ IncidenciaId = 21, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 3, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosReproceso.ElementAt(0) , DefectoId = defectosReproceso.ElementAt(0).DefectoId , EncontradoEnPie = pies.ElementAt(0) , PieId = 1 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 22, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 3, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosReproceso.ElementAt(0) , DefectoId = defectosReproceso.ElementAt(0).DefectoId , EncontradoEnPie = pies.ElementAt(0) , PieId = 1 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 23, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 3, Valor = 1, Hora = DateTime.Now , TipoIncidencia = tiposIncidencia.ElementAt(0), ClaseIncidenciaId = 1 },
                    new Incidencia{ IncidenciaId = 24, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 3, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosReproceso.ElementAt(2) , DefectoId = defectosReproceso.ElementAt(2).DefectoId , EncontradoEnPie = pies.ElementAt(0) , PieId = 1 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 25, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 3, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosReproceso.ElementAt(1) , DefectoId = defectosReproceso.ElementAt(1).DefectoId , EncontradoEnPie = pies.ElementAt(1) , PieId = 2 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 26, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 3, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosReproceso.ElementAt(1) , DefectoId = defectosReproceso.ElementAt(1).DefectoId , EncontradoEnPie = pies.ElementAt(1) , PieId = 2 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 27, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(0), JornadaLaboralId = 3, Valor = 1, Hora = DateTime.Now , DefectoEncontrado = defectosReproceso.ElementAt(3) , DefectoId = defectosReproceso.ElementAt(3).DefectoId , EncontradoEnPie = pies.ElementAt(0) , PieId = 1 , TipoIncidencia = tiposIncidencia.ElementAt(1), ClaseIncidenciaId = 2 },
                    new Incidencia{ IncidenciaId = 28, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 3, Valor = 1, Hora = DateTime.Now , TipoIncidencia = tiposIncidencia.ElementAt(0), ClaseIncidenciaId = 1 },
                    new Incidencia{ IncidenciaId = 29, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 3, Valor = 1, Hora = DateTime.Now , TipoIncidencia = tiposIncidencia.ElementAt(0), ClaseIncidenciaId = 1 },
                    new Incidencia{ IncidenciaId = 30, UsuarioId = 3, Creador = supervisorDeCalidad, Dueno = jornadas.ElementAt(1), JornadaLaboralId = 3, Valor = 1, Hora = DateTime.Now , TipoIncidencia = tiposIncidencia.ElementAt(0), ClaseIncidenciaId = 1 },
                };
                _dB.EstablecerIncidencias(incidencias3);

                
            }
        }

        private void ActualizarSemaforos()
        {
            OrdenDeProduccion orden = _dB.SeleccionarOrdenDeProduccion(1);
            LineaDeTrabajo linea = _dB.SeleccionarLinea(orden.NumeroDeLinea.LineaDeTrabajoId);


            orden.NumeroDeLinea.SemaforoObservados.Valor = 1;
            orden.NumeroDeLinea.SemaforoObservados.Estado = _dB.SeleccionarEstadoSemaforo(1);
            orden.NumeroDeLinea.SemaforoReproceso.Valor = 6;
            orden.NumeroDeLinea.SemaforoReproceso.Estado = _dB.SeleccionarEstadoSemaforo(2);

            _dB.ActualizarOrdenDeProduccion(orden);
        }

    }
}
