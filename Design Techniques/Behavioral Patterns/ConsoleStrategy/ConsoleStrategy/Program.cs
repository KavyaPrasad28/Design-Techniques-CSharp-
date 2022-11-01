using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStrategy
{
    /// <summary>
    /// Strategy is a behavioral design pattern that turns a set of behaviors into objects and makes them 
    /// interchangeable inside original context object.
    /// - Client code is disconnected from the strategy algorithm.
    /// - There can be a number of strategies in use as long as they fulfill a single interface contract.
    /// - The internal working of each strategy can be different.
    /// - Client can switch to a strategy based on the internal state of the system.
    /// - Client code selects the strategy it needs to use,
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}
