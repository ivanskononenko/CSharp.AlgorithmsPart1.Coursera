using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementarySorts
{
    public class SelectionSort
    {
        public void Sort(IComparable[] a)
        {
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                    if (less(a[j], a[min]))
                        min = j;
                exch(a, i, min);
            }
        }

        private bool less(IComparable v, IComparable w)
        {
            return false;
        }

        private void exch(IComparable[] v, int i, int j)
        {
        }
    }
}
