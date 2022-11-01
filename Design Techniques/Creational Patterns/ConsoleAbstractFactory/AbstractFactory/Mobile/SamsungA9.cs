using AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Mobile
{
    public class SamsungA9 : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("SamsungA9 mobile created...");
        }
    }
}
