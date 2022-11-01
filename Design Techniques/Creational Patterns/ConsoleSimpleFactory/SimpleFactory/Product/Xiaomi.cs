using SimpleFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Product
{
    public class Xiaomi : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("XiaomiRedmi mobile created...");
        }
    }
}
