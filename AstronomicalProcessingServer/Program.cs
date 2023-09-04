using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AstronomicalProcessingServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.	Create a ServiceHost and NetNamedPipeBinding in the “Program.cs” file to provide connection for the client(s).
            //      Ensure to add a Console.ReadLine to pause the program during operation.
            {
                string address = "net.pipe://localhost/pipemynumbers";

                ServiceHost serviceHost = new ServiceHost(typeof(AstroServer));
                NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
                serviceHost.AddServiceEndpoint(typeof(IAstroContract), binding, address);
                serviceHost.Open();

                Console.WriteLine("ServiceHost is running. Press <<Return>> to Exit");
                Console.ReadLine();
                serviceHost.Close();
            }
        }
    }
}
