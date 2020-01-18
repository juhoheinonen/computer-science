using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScience.Graphs
{
    public class Graph<T>
    {
        public List<Node<T>> Nodes { get; set; }

        public Graph()
        {
            Nodes = new List<Node<T>>();
        }
    }
}
