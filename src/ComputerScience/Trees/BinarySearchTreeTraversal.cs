using System;
using System.Collections;
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
            if (btree == null)
            {
                return;
            }

            int currentLevel = 0;

            var levelsDictionary = new SortedDictionary<int, Queue<T>>();
            levelsDictionary[currentLevel] = new Queue<T>();
            levelsDictionary[currentLevel].Enqueue(btree.Value);

            LevelPrintInner(btree.LeftChild, levelsDictionary, currentLevel + 1);
            LevelPrintInner(btree.RightChild, levelsDictionary, currentLevel + 1);

            var highestLevel = levelsDictionary.Keys.Count - 1;

            foreach (var levelAndLevelQueue in levelsDictionary)
            {
                var level = levelAndLevelQueue.Key;
                var levelQueue = levelAndLevelQueue.Value;

                var offSet = new string(' ', highestLevel - level);
                Console.Write(offSet);

                while (levelQueue.Count > 0)
                {                                                            
                    Console.Write(" " + levelQueue.Dequeue());
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private static void LevelPrintInner<T>(BinaryTreeNode<T> btree, SortedDictionary<int, Queue<T>> levelsDictionary, int currentLevel) where T : IComparable
        {
            if (btree == null)
            {
                return;
            }

            if (!levelsDictionary.ContainsKey(currentLevel))
            {
                levelsDictionary[currentLevel] = new Queue<T>();                
            }
            levelsDictionary[currentLevel].Enqueue(btree.Value);

            LevelPrintInner(btree.LeftChild, levelsDictionary, currentLevel + 1);
            LevelPrintInner(btree.RightChild, levelsDictionary, currentLevel + 1);
        }
    }
}
