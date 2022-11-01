using FactoryMethod;
using FactoryMethod.Factory;
using FactoryMethod.FactoryInterface;
using FactoryMethod.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactoryMethod
{
    /// <summary>
    /// Factory Method:-
    /// "Define an interface for creating an object, but let subclasses decide which class to instantiate.
    /// Factory Method lets a class defer instantiation to subclasses."
    /// Objective:-
    /// -To make Client unaware of the object instantiation.
    /// -Client should accesss the objects through a common interface.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Factory Method is used to create only one product, that is nothing but it deals with instatntiating
        /// only one required subclass.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IMobileFactory mobileFactory1 = new XiaomiFactory();//Client can swap between other factories seamlessly.
            IMobile mobile1 = mobileFactory1.GetMobile(ModelType.RedmiPro);
            mobile1.GetMobile();
            /*IMobile mobile2 = mobileFactory1.GetMobile(ModelType.Redmi6);
            mobile2.GetMobile();*/

            //IMobileFactory mobileFactory2 = new SamsungFactory();
            /*IMobile mobile3 = mobileFactory2.GetMobile(ModelType.A9);
            mobile3.GetMobile();*/
            /*IMobile mobile4 = mobileFactory2.GetMobile(ModelType.Galaxy);
            mobile4.GetMobile();*/
        }
    }
}
