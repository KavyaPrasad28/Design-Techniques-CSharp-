using FactoryMethod.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public class SamsungA9 : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("SamsungA9 mobile created...");
        }
    }
}
