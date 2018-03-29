using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace EventsLibHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri httpUrl = new Uri("http://localhost:9011/CalcService");

            ServiceHost host = new ServiceHost(typeof(EventsLib.CalcService), httpUrl);

            //endpoint
            host.AddServiceEndpoint(typeof(EventsLib.ICalcService), new WSDualHttpBinding(), "");

            //metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior
            {
                HttpGetEnabled = true
            };
            host.Description.Behaviors.Add(smb);

            host.Open();

            Console.WriteLine("Service running…");
            Console.ReadKey();
            host.Close();
        }
    }
}
