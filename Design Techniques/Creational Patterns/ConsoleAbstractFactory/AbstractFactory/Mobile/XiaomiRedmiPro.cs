using AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Mobile
{
    public class XiaomiRedmiPro : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("XiaomiRedmiPro mobile created...");
        }
    }
}
