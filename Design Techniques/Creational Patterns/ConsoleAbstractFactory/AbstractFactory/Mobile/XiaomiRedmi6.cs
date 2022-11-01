using AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Mobile
{
    public class XiaomiRedmi6 : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("XiaomiRedmi6 mobile created...");
        }
    }
}
