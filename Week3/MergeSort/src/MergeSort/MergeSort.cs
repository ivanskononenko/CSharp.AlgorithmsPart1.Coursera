

using System;
using System.Collections.Generic;
using System.Security;

namespace MergeSort
{
    public class MergeSort
    {
        private static IComparable[] aux;
        public void sort(IComparable[] a)
        {
            int N = a.Length;
            //aux = new List<int>();
            for (int sz = 1; sz < N; sz = sz + sz)
            {
                for (int lo = 0; lo < N - sz; lo += sz + sz)
                    merge(a, lo, lo + sz + 1, Math.Min(lo + sz + sz - 1, N - 1));
            }

        }

        private void merge(IComparable[] a, int lo, int mid, int hi)
        {
        }

    }
}
