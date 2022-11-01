using SimpleFactory;
using SimpleFactory.ProductInterface;
using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Factory
{
    public class MobileFactory
    {
        public static IMobile CreateMobile(BrandType modelType)
        {
            switch(modelType)
            {
                case BrandType.Samsung:
                    return new Samsung();
                case BrandType.Xiaomi:
                    return new Xiaomi();
                default:
                    throw new Exception("Invalid model type!");
            }
        }
    }
}
