using AbstractFactory.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FactoryInterface
{
    public interface IMobileFactory
    {
        IMobile GetMobile(ModelType modelType);
        ISignal GetSignalStrength(ModelType modelType);
    }
}
