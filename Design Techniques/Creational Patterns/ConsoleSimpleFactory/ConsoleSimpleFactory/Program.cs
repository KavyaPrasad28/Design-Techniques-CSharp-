using SimpleFactory;
using SimpleFactory.Factory;
using SimpleFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSimpleFactory
{
    /// <summary>
    /// Simple Factory Advantages:
    /// * Centralized object creation
    /// * Enhances scalability and testability of the application
    /// * Enhances code maintainability
    /// * Automatically adhers to SOLID principles.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IMobile mobile = MobileFactory.CreateMobile(BrandType.Samsung);
            mobile.GetMobile();
            /*IMobile mobile2 = MobileFactory.CreateMobile(BrandType.Xiaomi);
            mobile2.GetMobile();*/
        }
    }
}
