using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleObserver
{
    /// <summary>
    /// Observer is a behavioral design pattern that allows some objects to notify other objects about changes in their
    /// state.
    /// The Observer pattern provides a way to subscribe and unsubscribe to and from these events for any object that 
    /// implements a subscriber interface.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();
        }
    }
}
