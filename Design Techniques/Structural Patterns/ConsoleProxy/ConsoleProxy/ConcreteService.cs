using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProxy
{
    // The ConcreteService contains some core business logic. Usually, ConcreteService
    // are capable of doing some useful work which may also be very slow or
    // sensitive - e.g. correcting input data. A Proxy can solve these issues
    // without any changes to the ConcreteService's code.
    public class ConcreteService : IService
    {
        public void Login(int age)
        {
            Console.WriteLine($"You are logged in. Your age is {age}");
        }
    }
}
