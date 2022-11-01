using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardSingleton.Singleton
{
    /// <summary>
    /// Singleton class Properties:-
    /// -A sealed class(so that other classes cannot inherit this class)
    /// -A parameterless, single, private constructor(to prevent creating instance)
    /// -A private static field to hold the only instance of the class
    /// -A public static method/property which creates the instance
    /// </summary>
    public sealed class Logger
    {
        private static Logger _instance;//field to hold singleton instance
        private Logger()
        {
            Console.WriteLine("Logger constructor executed\n");
        }
        /// <summary>
        /// public property to access the instance globally
        /// </summary>
        public static Logger Instance
        {
            get
            {
                if (_instance == null)//the instance should be created only when it has never been created
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }
        public void LogInfo(string message)//additional method to log the message
        {
            Console.WriteLine(message);
        }
    }
}
