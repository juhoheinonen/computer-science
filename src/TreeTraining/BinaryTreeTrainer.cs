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

            Console.WriteLine("Root: " + btree.Root );
            Console.WriteLine();

            Console.WriteLine("Preorder:");
            Console.WriteLine();
            BinarySearchTreeTraversal.PreOrderPrint(btree);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Inorder:");
            Console.WriteLine();
            BinarySearchTreeTraversal.InOrderPrint(btree);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Postorder:");
            Console.WriteLine();
            BinarySearchTreeTraversal.PostOrderPrint(btree);
        }        
    }
}
