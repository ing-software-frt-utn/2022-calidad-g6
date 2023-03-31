
using ServicioWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Servidor...");
            Factoria factoria = Factoria.Instance;
            Uri baseAddress = new Uri("http://localhost:8080/ControlDeCalidadServicio");

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

                Console.WriteLine("El servicio se inicio en la direccion: {0}", baseAddress);
                Console.WriteLine("Presione <Enter> para detener el servicio.");
                Console.ReadLine();
                Console.WriteLine("Deteniendo el servicio...");
                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
