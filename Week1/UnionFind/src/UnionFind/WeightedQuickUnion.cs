namespace UnionFind
{
    public class WeightedQuickUnion
    {
        private readonly int[] ids;
        private readonly int[] size;

        public WeightedQuickUnion(int N)
        {
            ids = new int[N];
            size = new int[N];

            for (var i = 0; i < N; i++)
            {
                ids[i] = i;
            }
        }

        private int root(int i)
        {
            while (i != ids[i])
                i = ids[i];
            return i;
        }

        public bool connected(int p, int q)
        {
            return root(p) == root(q);
        }

        public void union(int p, int q)
        {
            var i = root(p);
            var j = root(q);
            ids[i] = j;
        }
    }
}