using AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Signal
{
    public class XiaomiRedmiProSignal : ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Xiaomi Redmi Pro has poor signal strength. Consider changing mobile network !");
        }
    }
}
