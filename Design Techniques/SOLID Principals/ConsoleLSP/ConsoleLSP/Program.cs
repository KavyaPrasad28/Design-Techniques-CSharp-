using LSPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLSP
{
    /// <summary>
    /// The Liskov Substitution Principle (LSP) states that "you should be able to use any derived class instead of a parent class and have it behave in the same manner without modification". It ensures that a derived class does not affect the behavior of the parent class, in other words,, that a derived class must be substitutable for its base class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BaseEmployee ceo = new CEO();
            ceo.FirstName = "Jhon";
            ceo.LastName = "Joseph";
            ceo.CalculatePerHourRate(4);
            Console.WriteLine($"{ceo.FirstName}'s Salary is ${ceo.Salary}/hour.");

            BaseEmployee accountingVP = new Manager();
            accountingVP.FirstName = "Kavya";
            accountingVP.LastName = "Prasad";
            accountingVP.CalculatePerHourRate(4);

            Console.WriteLine($"{accountingVP.FirstName}'s Salary is ${accountingVP.Salary}/hour.");

            Employee emp = new Employee();

            emp.FirstName = "Josh";
            emp.LastName = "Samuel";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s Salary is ${emp.Salary}/hour.");
        }
    }
}
