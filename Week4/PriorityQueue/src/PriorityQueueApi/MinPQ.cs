using System;

namespace PriorityQueueApi
{
    public class MinPQ<TKey> : IMinPriorityQueue<TKey> where TKey : IComparable
    {
        private TKey[] _pq;

        private int N = 0;

        public MinPQ(int maxN)
        {
            _pq = new TKey[maxN + 1];
        }
        public TKey delMin()
        {
            throw new NotImplementedException();
        }

        public void insert(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool isEmpty()
        {
            throw new NotImplementedException();
        }

        public TKey min()
        {
            throw new NotImplementedException();
        }

        public int size()
        {
            throw new NotImplementedException();
        }

        private bool less(int i, int j)
        {
            return _pq[i].CompareTo(_pq[j]) < 0;
        }

        private void exch(int i, int j)
        {
            TKey tmp = _pq[i];
            _pq[i] = _pq[j];
            _pq[j] = tmp;
        }

        private void swim(int k)
        {
            while (k > 1 && less(k / 2, k))
            {
                exch(k / 2, 2);
                k = k / 2;
            }
        }

        private void sink(int k)
        {
            while (2 * k <= N)
            {
                int j = 2 * k;
                if (j < N && less(j, j + 1))
                {
                    j++;
                }

                if (!less(k, j))
                {
                    break;
                }

                exch(k, j);
                k = j;
            }
        }
    }
}
