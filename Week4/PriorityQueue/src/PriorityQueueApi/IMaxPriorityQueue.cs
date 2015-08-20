using System;

namespace PriorityQueueApi
{
    public interface IMaxPriorityQueue<TKey> where TKey : IComparable
    {
        void insert(TKey key);
        TKey max();
        TKey delMax();
        bool isEmpty();
        int size();
    }
}
