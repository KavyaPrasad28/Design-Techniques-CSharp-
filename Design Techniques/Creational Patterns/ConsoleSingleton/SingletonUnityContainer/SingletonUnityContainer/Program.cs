using Microsoft.Practices.Unity;
using SingletonUnityContainer.Singleton;
using System;

namespace SingletonUnityContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<Logger>();//register logger class

            //tells the container that when Ilogger is requested give the instance of logger class
            container.RegisterType<ILogger, Logger>(new ContainerControlledLifetimeManager());//to make unity container multiple instances on every request change the life time of instance ContainerControlledLifetimeManager() to TransientLifetimeManager()

            CustomerOrder order_1 = container.Resolve<CustomerOrder>();//when Resolve is called container instantiates the given class
            order_1.PlaceOrder(1);

            CustomerOrder order_2 = container.Resolve<CustomerOrder>();
            order_2.PlaceOrder(2);
        }
    }
}
