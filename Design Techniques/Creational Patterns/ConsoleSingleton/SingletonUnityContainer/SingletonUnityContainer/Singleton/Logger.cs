using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonUnityContainer.Singleton
{
    /// <summary>
    /// Singleton class Properties:-
    /// -A sealed class(so that other classes cannot inherit this class)
    /// -A parameterless, single, private constructor(to prevent creating instance)
    /// -A private static field to hold the only instance of the class
    /// -A public static method/property which creates the instance
    /// </summary>
    public sealed class Logger : ILogger
    {
        public Logger()//no need make private because it's the responsibility of the container to make singleton behaviour
        {
            Console.WriteLine("Logger constructor executed\n");
        }
        public void LogInfo(string message)//additional method to log the message
        {
            Console.WriteLine(message);
        }
    }
}
