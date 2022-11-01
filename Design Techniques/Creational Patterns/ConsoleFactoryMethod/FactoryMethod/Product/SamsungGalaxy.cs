using FactoryMethod.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public class SamsungGalaxy : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Samsung Galaxy mobile created...");
        }
    }
}
