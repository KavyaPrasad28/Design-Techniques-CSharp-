using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassAdapterPattern
{
    public interface ISales
    {
        void ShowSalesData(XmlNode xmlSalesData);
    }
}
