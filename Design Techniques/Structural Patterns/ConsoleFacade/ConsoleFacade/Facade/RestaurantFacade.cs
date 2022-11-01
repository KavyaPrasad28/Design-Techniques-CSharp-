using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFacade
{
    //Facade is a structural design pattern that provides a simplified (but limited) interface to a complex system of classes, library or framework.
    //While Facade decreases the overall complexity of the application, it also helps to move unwanted dependencies to one place.
    // The Facade delegates the client requests to the appropriate objects within the subsystem.
    /// <summary>
    /// Used by the client to order different pizzas or breads.
    /// </summary>
    public class RestaurantFacade
    {
        private IPizza _PizzaProvider;
        private IBread _BreadProvider;
        public RestaurantFacade()
        {
            _PizzaProvider = new PizzaProvider();
            _BreadProvider = new BreadProvider();
        }
        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public void GetNonVegPizza()
        {
            _PizzaProvider.GetNonVegPizza();
        }
        public void GetVegPizza()
        {
            _PizzaProvider.GetVegPizza();
        }
        public void GetGarlicBread()
        {
            _BreadProvider.GetGarlicBread();
        }
        public void GetCheesyGarlicBread()
        {
            _BreadProvider.GetCheesyGarlicBread();
        }
    }
}
