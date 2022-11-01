using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonThreadSafe.Singleton
{
    /// <summary>
    /// Use the logger class to log the info
    /// </summary>
    public class CustomerOrder
    {
        private readonly Logger _logger;
        public CustomerOrder()
        {
            _logger = Logger.Instance;
        }
        public void PlaceOrder(int orderNumber)
        {
            //calls related to placing order...
            _logger.LogInfo($"Order number {orderNumber} is processed successfully");
        }
    }
}
