using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSRP
{
    /// <summary>
    /// SRP - Single Responsibility Pinciple
    /// "A class should have only one job".
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if(!isUserValid)
            {
                Console.Write("Press Enter to close...");
                StandardMessages.EndApplication();
                return;//here return closes the application.
            }

            AccountGenerator.CreateAccount(user);
            Console.Write("Press Enter to close...");
            StandardMessages.EndApplication();
        }
    }
}
