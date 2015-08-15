using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class QuickSort : ISort
        {
            public bool less(IComparable v, IComparable w)
            {
                return v.CompareTo(w) < 0;
            }
            public void exch(IComparable[] arr, int i, int j)
            {
                IComparable tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }

            private int partition(IComparable[] a, int lo, int hi)
            {
                int i = lo;
                int j = hi + 1;
                IComparable v = a[lo];
                while (true)
                {

                    // find item on lo to swap
                    while (less(a[++i], v))
                        if (i == hi) break;

                    // find item on hi to swap
                    while (less(v, a[--j]))
                        if (j == lo) break; // redundant since a[lo] acts as sentinel

                    // check if pointers cross
                    if (i >= j) break;

                    exch(a, i, j);
                }

                // put partitioning item v at a[j]
                exch(a, lo, j);

                // now, a[lo .. j-1] <= a[j] <= a[j+1 .. hi]
                return j;
            }

            public void Sort(IComparable[] arr)
            {

            }
        }

        public interface ISort
        {
            bool less(IComparable v, IComparable w);
            void exch(IComparable[] arr, int i, int j);
            void Sort(IComparable[] arr);
        }

    }
}
