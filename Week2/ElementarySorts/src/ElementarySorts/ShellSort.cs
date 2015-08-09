using System;

namespace ElementarySorts
{
    public class ShellSort : ISort
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

        public void Sort(IComparable[] arr)
        {
            int N = arr.Length;
            int h = 1;
            while (h < N / 3)
            {
                h = 3 * h + 1;
            }

            while (h >= 1)
            {
                for (int i = h; i < N; i++)
                {
                    //for (int j = i; j >= h && less(arr[j], arr[j - h]); j -= h)
                    for (int j = i; j >= h; j = j - h)
                    {
                        if (less(arr[j], arr[j - h]))
                            exch(arr, j, j - h);
                    }
                }
                h = h / 3;
            }

        }
    }
}
