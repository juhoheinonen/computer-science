using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScience.Trees
{
    public class BinarySearchTreeTraversal
    {
        public static void PreOrderPrint<T>(BinaryTreeNode<T> btree) where T : IComparable
        {
            Console.Write(" " + btree.Value);

            if (btree.LeftChild != null)
            {
                PreOrderPrint(btree.LeftChild);
            }

            if (btree.RightChild != null)
            {

                PreOrderPrint(btree.RightChild);
            }
        }

        public static void InOrderPrint<T>(BinaryTreeNode<T> btree) where T : IComparable
        {
            if (btree.LeftChild != null)
            {
                InOrderPrint(btree.LeftChild);
            }

            Console.Write(" " + btree.Value);

            if (btree.RightChild != null)
            {

                InOrderPrint(btree.RightChild);
            }
        }

        public static void PostOrderPrint<T>(BinaryTreeNode<T> btree) where T : IComparable
        {
            if (btree.LeftChild != null)
            {
                PostOrderPrint(btree.LeftChild);
            }

            if (btree.RightChild != null)
            {
                PostOrderPrint(btree.RightChild);
            }

            Console.Write(" " + btree.Value);
        }

        public static void LevelPrint<T>(BinaryTreeNode<T> btree) where T : IComparable
        {
            var levelQueue = new Queue<T>();

            if (btree.Parent == null)
            {
                levelQueue.Enqueue(btree.Value);
            }

            levelQueue.Enqueue(btree.LeftChild.Value);
            levelQueue.Enqueue(btree.RightChild.Value);



        }
    }
}
