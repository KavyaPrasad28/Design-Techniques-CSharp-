using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIterator_new
{
    public class Iterator : IIterator
    {
        private Collection collection;
        private int current;
        public Iterator(Collection collection)
        {
            this.collection = collection;
            current = 0;
        }
        public object First()
        {
            return collection[0];
        }
        public object Next()
        {
            if(!IsDone())
            {
                object obj = collection[current];
                current++;
                return obj;
            }
            return null;
        }
        /// <summary>
        /// whenever traversing is finished it will return true otherwise false.
        /// </summary>
        /// <returns></returns>
        public bool IsDone()
        {
            return current >= collection.Count;
        }

        public object CurrentItem()
        {
            if (!IsDone())
                return collection[current];
            return null;
        }

    }
}
