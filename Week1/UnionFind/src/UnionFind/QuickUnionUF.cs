
namespace UnionFind
{
    public class QuickUnionUF
    {
        private int[] ids;

        public QuickUnionUF(int N)
        {
            ids = new int[N];
            for (int i = 0; i < N; i++)
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
            int i = root(p);
            int j = root(q);
            ids[i] = j;
        }
    }
}
