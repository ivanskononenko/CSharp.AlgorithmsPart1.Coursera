using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace PriorityQueueApi
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(args[0]);
            string filePath = args[1];

            int N = 12;

            string[] lines = File.ReadAllLines(filePath);
            MinPQ<int> pq = new MinPQ<int>(lines.Length);
            foreach (var line in lines)
            {
                int el = int.Parse(line);
                pq.insert(el);

                if (pq.size() > M)
                {
                    pq.delMin();
                }
            }

            System.Collections.Generic.Stack<int> stack = new System.Collections.Generic.Stack<int>();

            while (!pq.isEmpty())
            {
                stack.Push(pq.delMin());
            }

            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

        }
    }
}
