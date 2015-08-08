
using System;

namespace ElementarySorts
{
    public interface ISort
    {
        bool less(IComparable v, IComparable w);
        void exch(IComparable[] arr, int i, int j);
        void Sort(IComparable[] arr);
    }
}
