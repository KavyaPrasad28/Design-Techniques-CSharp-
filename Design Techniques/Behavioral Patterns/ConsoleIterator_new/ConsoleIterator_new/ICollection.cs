using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIterator_new
{
    public interface ICollection
    {
        Iterator CreateIterator();
    }
}
