using System.Collections.Generic;

namespace ComputerScience.Graphs
{
    public class Node<T>
    {
        public T Value { get; set; }        

        public bool Visited { get; set; }

        public bool Marked { get; set; }

        public List<Node<T>> Children { get; set; }

        public Node(T value)
        {
            Value = value;
            Children = new List<Node<T>>();
            Visited = false;
            Marked = false;
        }
    }
}
