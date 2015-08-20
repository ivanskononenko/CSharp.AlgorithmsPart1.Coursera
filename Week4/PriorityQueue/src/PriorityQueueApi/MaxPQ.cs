using System;

namespace PriorityQueueApi
{
    public class MaxPQ<TKey> : IMaxPriorityQueue<TKey> where TKey : IComparable
    {
        private TKey[] _pq;

        private int N = 0;

        public MaxPQ(int maxN)
        {
            _pq = new TKey[maxN + 1];
        }

        public TKey delMax()
        {
            TKey max = _pq[1];
            exch(1, N--);
            _pq[N + 1] = default(TKey);
            sink(1);
            return max;
        }

        public void insert(TKey key)
        {
            _pq[++N] = key;
            swim(N);
        }

        public bool isEmpty()
        {
            return N == 0;
        }

        public TKey max()
        {
            return _pq[1];
        }

        public int size()
        {
            return N;
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
