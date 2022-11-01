using SingletonThreadSafe.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SingletonThreadSafe
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                CustomerOrder order_1 = new CustomerOrder();
                order_1.PlaceOrder(1);
            }).Start();

            new Thread(() =>
            {
                CustomerOrder order_2 = new CustomerOrder();
                order_2.PlaceOrder(2);
            }).Start();
        }
    }
}
