using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProxy
{
    // The client code is supposed to work with all objects (both subjects
    // and proxies) via the IService interface in order to support both real
    // subjects and proxies. In real life, however, clients mostly work with
    // their real service directly. In this case, to implement the pattern
    // more easily, you can extend your proxy from the real service's class.
    public class Client
    {
        public IService ClientCode(IService service)
        {
            service.Login(15);
            service.Login(19);
            return service;
        }
    }
}
