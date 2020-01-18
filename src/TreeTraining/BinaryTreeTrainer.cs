using ComputerScience;
using ComputerScience.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeTraining
{
    public class BinaryTreeTrainer
    {
        internal void Run(int[] input)
        {
            var btree = new BinaryTreeNode<int>();
            btree.Parent = btree;
            btree.Value = input.First();

            foreach (var inputInt in input.Skip(1))
            {
                btree.Insert(inputInt);
            }

            Console.WriteLine("Root: " + btree.Root);
            Console.WriteLine();

            Console.WriteLine("Min: " + btree.Min.Value);
            Console.WriteLine();

            Console.WriteLine("Max: " + btree.Max.Value);
            Console.WriteLine();

            //Console.WriteLine("Preorder:");
            //Console.WriteLine();
            //BinarySearchTreeTraversal.PreOrderPrint(btree);
            //Console.WriteLine();
            //Console.WriteLine();

            Console.WriteLine("Inorder:");
            Console.WriteLine();
            BinarySearchTreeTraversal.InOrderPrint(btree);
            Console.WriteLine();
            Console.WriteLine();

            //Console.WriteLine("Postorder:");
            //Console.WriteLine();
            //BinarySearchTreeTraversal.PostOrderPrint(btree);

            Console.WriteLine("Level traversal:");
            Console.WriteLine();
            BinarySearchTreeTraversal.LevelPrint(btree);
        }

        internal void MinimalTree()
        {
            var inputs = new List<List<int>>();
            inputs.Add(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            inputs.Add(new List<int> { 1, 2 });
            inputs.Add(new List<int> { 1 });
            inputs.Add(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});

            foreach (var input in inputs)
            {
                BinaryTreeNode<int> tree = CreateMinimalTree(input.ToArray());
                Console.WriteLine("Level traversal:");
                Console.WriteLine();
                BinarySearchTreeTraversal.LevelPrint(tree);
            }

            //var input = new int[9];
            //for (int i = 0; i < input.Length; i++)
            //{
            //    input[i] = i + 1;
            //}

            //BinaryTreeNode<int> tree = CreateMinimalTree(input);

            //Console.WriteLine("Level traversal:");
            //Console.WriteLine();
            //BinarySearchTreeTraversal.LevelPrint(tree);


            //input = new int[0];
            //for (int i = 0; i < input.Length; i++)
            //{
            //    input[i] = i + 1;
            //}

            //tree = CreateMinimalTree(input);
            //Console.WriteLine("Level traversal:");
            //Console.WriteLine();
            //BinarySearchTreeTraversal.LevelPrint(tree);


            //input = new int[1];
            //for (int i = 0; i < input.Length; i++)
            //{
            //    input[i] = i + 1;
            //}

            //tree = CreateMinimalTree(input);
            //Console.WriteLine("Level traversal:");
            //Console.WriteLine();
            //BinarySearchTreeTraversal.LevelPrint(tree);

        }

        private BinaryTreeNode<int> CreateMinimalTree(int[] a)
        {
            if (a.Length > 0)
            {
                var node = new BinaryTreeNode<int>();
                int medianIndex = (a.Length - 1) / 2;
                int median = a[medianIndex];
                node.Value = median;

                var left = a.Take(medianIndex).ToArray();

                node.LeftChild = CreateMinimalTree(left);

                var right = a.Skip(medianIndex + 1).ToArray();

                node.RightChild = CreateMinimalTree(right);

                return node;
            }

            return null;
        }
    }
}
