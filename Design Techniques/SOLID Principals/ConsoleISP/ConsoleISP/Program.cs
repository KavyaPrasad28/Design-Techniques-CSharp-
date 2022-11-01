using ISPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleISP
{
    /// <summary>
    /// The Interface Segregation Principle states "that clients should not be forced to implement interfaces they don't use. Instead of one fat interface, many small interfaces are preferred based on groups of methods, each one serving one submodule".
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IBorrowableDVD dvd = new DVD();
            dvd.CheckOut("Lim");
            Console.WriteLine(dvd.Borrower);
            Console.WriteLine(dvd.BorrowDate);
        }
    }
}
