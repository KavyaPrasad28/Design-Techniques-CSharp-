using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProxy
{
    //Proxy Pattern - "Provide a surrogate or placeholder for another object to control access to it."
    /// <summary>
    /// Proxy is a structural design pattern that provides an object that acts as a substitute for a real service object used by a client. A proxy receives client requests, does some work (access control, caching, etc.) and then passes the request to a service object.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            IService concreteService = new ConcreteService();
            client.ClientCode(concreteService);

            IService proxy = new Proxy(concreteService);
            client.ClientCode(proxy);
            /*IService concreteService = new ConcreteService();
            IService proxy = new Proxy(concreteService);

            concreteService.Login(15);//without proxy
            proxy.Login(15);

            concreteService.Login(19);//without proxy
            proxy.Login(19);*/
        }
    }
}
