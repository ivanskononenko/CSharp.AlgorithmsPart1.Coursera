﻿using System;

namespace ElementarySorts
{
    public class InsertionSort: ISort
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
                }
            }
        }

    }
}
