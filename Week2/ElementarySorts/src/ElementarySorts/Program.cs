using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementarySorts
{
    class Program
    {
        static void Main(string[] args)
        {
            IComparable[] elements = { 11, 7, 12, 10, 8, 15, 2, 43, 25, 1 };

            //ISort sortAlg = new BubbleSort();
            //ISort sortAlg = new InsertionSort();
            ISort sortAlg = new ShellSort();
            sortAlg.Sort(elements);

            foreach (int el in elements)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
    }
}
