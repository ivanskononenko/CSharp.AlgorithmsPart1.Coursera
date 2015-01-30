
namespace UnionFind
{
    public class QuickFindUF
    {
        private int[] ids;

        public QuickFindUF(int N)
        {
            ids = new int[N];
            for (int i = 0; i < N; i++)
            {
                ids[i] = i;
            }
        }

        public bool connected(int p, int q)
        {
            return ids[p] == ids[q];
        }

        public void union(int p, int q)
        {
            if (connected(p, q))
                return;

            int pId = ids[p];
            int qId = ids[q];

            for (int i = 0; i < ids.Length; i++)
            {
                if (ids[i] == pId)
                    ids[i] = qId;

            }
        }

    }
}
