using GraphReport;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassAdapterPattern
{
    /// <summary>
    /// Class Adapter Pattern : When Adapter class implements an interface and resolves the incompatibility.
    /// </summary>
    //need to convert xml to json (use Nuget Newtonsoft.Json)
    public class SalesDataPresenterAdapter : ISales
    {
        private readonly IGraph _graph;
        public SalesDataPresenterAdapter(IGraph graph)
        {
            _graph = graph;
        }
        public void ShowSalesData(XmlNode xmlSalesData)
        {
            var jSon = JsonConvert.SerializeXmlNode(xmlSalesData);
            _graph.ShowGraph(jSon);
        }
    }
}
