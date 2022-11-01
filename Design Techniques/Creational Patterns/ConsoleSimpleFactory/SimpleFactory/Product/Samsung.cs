using SimpleFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Product
{
    public class Samsung : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Samsung mobile created...");
        }
    }
}
