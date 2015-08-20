using System;

namespace PriorityQueueApi
{
    public interface IMinPriorityQueue<TKey> where TKey : IComparable
    {
        void insert(TKey key);
        TKey min();
        TKey delMin();
        bool isEmpty();
        int size();
    }
}
