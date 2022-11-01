using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIterator_new
{
    public class Collection : ICollection
    {
        private ArrayList items = new ArrayList();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        public int Count
        {
            get
            {
                return items.Count;
            }
        }
        /// <summary>
        /// Indexers allow instances of a class or struct to be indexed just like arrays. 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                return (int)items[index];
            }
            set
            {
                items.Add(value);
            }
        }
    }
}
