using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIterator_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            collection[0] = 1;
            collection[1] = 2;
            collection[2] = 3;
            collection[3] = 4;
            collection[4] = 5;
            collection[5] = 6;
            collection[6] = 7;
            collection[7] = 8;
            collection[8] = 9;
            collection[9] = 10;

            Iterator iterator = new Iterator(collection);
            Console.WriteLine("Iterating the collection...");
            Console.WriteLine(iterator.CurrentItem());
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
            Console.WriteLine(iterator.First());
        }
    }
}
