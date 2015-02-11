using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementarySorts
{
    public class InsertionSort
    {
        public void Sort(IComparable[] a)
        {
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (less(a[j], a[j - 1]))
                    {
                        exch(a, j, j - 1);
                    }
                    else
                    {
                        break;
                    }
                }
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
