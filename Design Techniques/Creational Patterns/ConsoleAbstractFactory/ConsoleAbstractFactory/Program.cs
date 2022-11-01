using AbstractFactory;
using AbstractFactory.Factory;
using AbstractFactory.FactoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAbstractFactory
{
    /// <summary>
    /// Abstract Factory:-
    /// Provide an interface for creating families of related or dependent objects without specifying
    /// their concrete classes.
    /// -Hides construction of related objects
    /// -Encapsulates a group of individual factories
    /// -Promotes consistency among products
    /// -Can create families of related or dependent objects while factory method can only create one object
    /// -Easy product family exchange
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IMobileFactory mobileFactory = new XiaomiFactory();
            mobileFactory.GetMobile(ModelType.RedmiPro).GetMobile();
            mobileFactory.GetSignalStrength(ModelType.RedmiPro).ShowSignalStrength();
        }
    }
}
