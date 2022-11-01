using FactoryMethod.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.FactoryInterface
{
    public interface IMobileFactory
    {
        IMobile GetMobile(ModelType modelType);
    }
}
