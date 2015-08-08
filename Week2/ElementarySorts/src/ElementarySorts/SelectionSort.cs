using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementarySorts
{
    public class SelectionSort: BaseSort
    {
        public override void Sort(IComparable[] a)
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
    }
}
