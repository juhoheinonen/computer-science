using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerScience.Graphs
{
    public static class GraphTraversal
    {
        public static void DepthFirstTraversal<T>(Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.Value + " ");

            root.Visited = true;

            foreach (var child in root.Children.Where(c => !c.Visited))
            {
                DepthFirstTraversal<T>(child);
            }
        }

        public static void BreadthFirstTraversal<T>(Node<T> root)
        {
            var queue = new Queue<Node<T>>();
            root.Marked = true;
            queue.Enqueue(root);

            while (queue.Any())
            {
                Node<T> r = queue.Dequeue();
                Visit(r);
                foreach (var n in r.Children)
                {
                    if (!n.Marked)
                    {
                        n.Marked = true;
                        queue.Enqueue(n);
                    }
                }
            }

        }

        private static void Visit<T>(Node<T> root)
        {            
            Console.WriteLine(root.Value);
        }
    }
}
