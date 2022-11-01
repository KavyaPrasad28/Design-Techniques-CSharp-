using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
        }
    }
}
