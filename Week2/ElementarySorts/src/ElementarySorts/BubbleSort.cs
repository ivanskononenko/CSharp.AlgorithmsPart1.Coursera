using System;

namespace ElementarySorts
{
    public class BubbleSort : ISort
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

            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < N - i; j++)
                {
                    if (less(arr[j + 1], arr[j]))
                    {
                        exch(arr, j + 1, j);
                    }
                }
            }

        }
    }
}
