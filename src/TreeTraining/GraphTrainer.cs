using ComputerScience.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingRunner
{
    public class GraphTrainer
    {
        internal void Run(string[] args)
        {
            //var graph = GenerateTestGraph1();

            //GraphTraversal.DepthFirstTraversal(graph.Nodes.First());

            //Console.WriteLine();

            //graph = GenerateTestGraph1();

            //GraphTraversal.BreadthFirstTraversal(graph.Nodes.First());

            var searchGraph = GenerateTestGraph2();

        }        

        private static Graph<int> GenerateTestGraph1()
        {
            var graph = new Graph<int>();

            for (int i = 0; i < 6; i++)
            {
                graph.Nodes.Add(new Node<int>(i));
            }

            graph.Nodes[0].Children.Add(graph.Nodes[1]);
            graph.Nodes[0].Children.Add(graph.Nodes[4]);
            graph.Nodes[0].Children.Add(graph.Nodes[5]);

            graph.Nodes[1].Children.Add(graph.Nodes[3]);
            graph.Nodes[1].Children.Add(graph.Nodes[4]);

            graph.Nodes[1].Children.Add(graph.Nodes[3]);
            graph.Nodes[1].Children.Add(graph.Nodes[4]);

            graph.Nodes[2].Children.Add(graph.Nodes[1]);

            graph.Nodes[3].Children.Add(graph.Nodes[2]);
            graph.Nodes[3].Children.Add(graph.Nodes[4]);
            return graph;
        }

        private Graph<int> GenerateTestGraph2()
        {
            var graph = new Graph<int>();

            graph.Nodes.Add(new Node<int>(0));
            graph.Nodes.Add(new Node<int>(2));
            graph.Nodes.Add(new Node<int>(4));
            graph.Nodes.Add(new Node<int>(5));
            graph.Nodes.Add(new Node<int>(6));
            graph.Nodes.Add(new Node<int>(8));
            graph.Nodes.Add(new Node<int>(5));
            graph.Nodes.Add(new Node<int>(7));
            graph.Nodes.Add(new Node<int>(8));
            graph.Nodes.Add(new Node<int>(100));
            graph.Nodes.Add(new Node<int>(5));

            var arr = new byte[10];
            bool test = arr.Count() == 3;

            return graph;
        }
    }
}
