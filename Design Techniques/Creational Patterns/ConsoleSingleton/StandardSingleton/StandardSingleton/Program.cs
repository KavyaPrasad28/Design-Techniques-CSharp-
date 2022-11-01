using StandardSingleton.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardSingleton
{
    /// <summary>
    /// Singleton pattern ensure a class has only one instance and provide a global point of access to it.
    /// Output:-
    /// Here only instance of logger class is used to log both the messages.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CustomerOrder order_1 = new CustomerOrder();
            order_1.PlaceOrder(1);

            CustomerOrder order_2 = new CustomerOrder();
            order_2.PlaceOrder(2);
        }
    }
}
