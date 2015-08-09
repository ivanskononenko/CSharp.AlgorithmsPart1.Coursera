using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementarySorts
{
    public class SelectionSort: ISort
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

        public  void Sort(IComparable[] a)
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
