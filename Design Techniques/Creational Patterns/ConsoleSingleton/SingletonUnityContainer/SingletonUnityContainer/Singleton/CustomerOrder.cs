using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonUnityContainer.Singleton
{
    /// <summary>
    /// Whenever customer order get instantiated, container will automatically inject ILogger instance to this class
    /// </summary>
    public class CustomerOrder
    {
        private readonly ILogger _logger;
        public CustomerOrder(ILogger logger)
        {
            _logger = logger;
        }
        public void PlaceOrder(int orderNumber)
        {
            //calls related to placing order...
            _logger.LogInfo($"Order number {orderNumber} is processed successfully");
        }
    }
}
