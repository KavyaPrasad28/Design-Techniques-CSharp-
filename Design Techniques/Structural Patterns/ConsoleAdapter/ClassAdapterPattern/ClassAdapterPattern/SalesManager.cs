using GraphReport;
using SalesDataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdapterPattern
{
    public class SalesManager
    {
        public void Process()
        {
            var salesData = new SalesDataReader().GetSalesData();
            ISales sales = new SalesDataPresenterAdapter(new DisplayGraph());//IGraph g = new DisplayGraph()
            sales.ShowSalesData(salesData);
        }
    }
}
