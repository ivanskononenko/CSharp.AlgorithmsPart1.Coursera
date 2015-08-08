
using System;

namespace ElementarySorts
{
    public class BaseSort : ISort
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

        public virtual void Sort(IComparable[] arr)
        {
            throw new NotImplementedException();
        }
    }
}
