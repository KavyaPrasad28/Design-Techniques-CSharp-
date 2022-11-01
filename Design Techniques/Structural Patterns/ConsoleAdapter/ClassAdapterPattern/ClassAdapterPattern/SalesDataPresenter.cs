using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassAdapterPattern
{
    public class SalesDataPresenter : ISales
    {
        public void ShowSalesData(XmlNode xmlSalesData)
        {
            Console.WriteLine(xmlSalesData.InnerXml);
        }
    }
}
