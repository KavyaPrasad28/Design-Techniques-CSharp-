using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphReport
{
    public class DisplayGraph : IGraph
    {
        public void ShowGraph(string jSonData)
        {
            // displays jSon Data in a nice graph
            Console.WriteLine(jSonData);
        }
    }
}
