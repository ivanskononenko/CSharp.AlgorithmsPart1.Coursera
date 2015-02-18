﻿using System;
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
    }

    public class QuickSort
    {
        private int partition(IComparable[] a, int lo, int hi)
        {
            int i = lo, j = hi + 1;
            while (true)
            {
                while (less(a[++i], a[lo]))
                    if (i == hi)
                        break;

                while (less(a[lo], a[--j]))
                    if (j == lo)
                        break;

                if (i >= j)
                    break;
                exch(a, i, j);
            }
            exch(a, lo, j);
            return j;
        }

        private bool less(IComparable i, IComparable j)
        {
            return false;
        }

        private void exch(IComparable[] a, int i, int j)
        {
        }
    }


}
