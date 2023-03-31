using Aplicacion.Administradores;
using Aplicacion.Interfaces;
using ServicioWeb;
using System;


namespace Presentacion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Servidor...");
            IAdministradorSesion adminSesion = AdministradorSesion.Instance;
            adminSesion.IniciarDB();
            Uri baseAddress = new Uri("http://localhost:8733/ControlDeCalidadServicio");

            // Create the ServiceHost.
            using (ServiceHost host = new ServiceHost(typeof(ServicioDeConexion), baseAddress))
            {
                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine("The service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }





        }
    }
}
