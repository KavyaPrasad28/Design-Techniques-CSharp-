using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProxy
{
    // The Proxy has an interface identical to the ConcreteService.
    // The most common applications of the Proxy pattern are lazy loading,
    // caching, controlling the access, logging, etc. A Proxy can perform
    // one of these things and then, depending on the result, pass the
    // execution to the same method in a linked ConcreteService object.
    public class Proxy : IService
    {
        private IService _service;
        public Proxy(IService service)
        {
            _service = service;
        }
        public void Login(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("You are too young");
            }
            else
            {
                _service.Login(age);
            }
        }
    }
}
