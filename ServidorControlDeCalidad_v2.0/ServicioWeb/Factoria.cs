using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Aplicacion.Administradores;
using Aplicacion.Interfaces;
using Dominio.Interfaces_DB;
using Persistencia.ConexionConDB;

namespace ServicioWeb
{
    public class Factoria
    {
        private static volatile Factoria _instance;
        private static readonly object _syncLock = new object();

        private UnityContainer _contenedor;
        public Factoria()
        {
            _contenedor = new UnityContainer();
            _contenedor.RegisterType< IAdministradorColores,  AdministradorColores >();
            _contenedor.RegisterType< IAdministradorDeLineas, AdministradorDeLineas >();
            _contenedor.RegisterType< IAdministradorJornadaLaboral, AdministradorJornadaLaboral >();
            _contenedor.RegisterType< IAdministradorModelos, AdministradorModelos >();
            _contenedor.RegisterType< IAdministradorOP, AdministradorOP >();
            _contenedor.RegisterType< IAdministradorSesion, AdministradorSesion >();
            _contenedor.RegisterType< IAdministradorUsuarios, AdministradorUsuarios >();
            _contenedor.RegisterType< IManagerDeDB, ManagerDeDB >();
            _contenedor.RegisterType < IInicializadorDeDB, InicializadorDeDB >();
            IInicializadorDeDB iniciadorDB = _contenedor.Resolve<IInicializadorDeDB>();
            IAdministradorSesion adminSesion = CrearAdministrador<AdministradorSesion>();
            
        }

        public static Factoria Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Factoria();
                    }
                }
                return _instance;
            }
        }

        public T CrearAdministrador<T>()
        {
            return _contenedor.Resolve<T>();
        }










    }
}
