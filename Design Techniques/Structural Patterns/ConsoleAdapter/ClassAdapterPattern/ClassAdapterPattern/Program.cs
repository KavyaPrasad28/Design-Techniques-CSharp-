using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdapterPattern
{
    /// <summary>
    /// This application should take data from SqlDataAccess Library and display data in xml format. But client wants the out in json format. DisplayGraph (already existing project ,(adaptee)) has a interface Igraph which shows the output in json format. So SalesManager Class want to use this Igraph interface. But the problem is that Igraph interface receives the input in json format. SalesManager doesnot want to couple the Igraph functionality as may be the developer may change the DisplayGraph to something else later. So here the 2 incompatible interface 'ISales' and 'IGraph'.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SalesManager manager = new SalesManager();
            manager.Process();//Output-Data will be displayed in xml format
        }
    }
}
