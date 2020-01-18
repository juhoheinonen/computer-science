using System;

namespace ComputerScience
{
    public class BinaryTreeNode<T> where T : IComparable
    {
        public T Value { get; set; }

        public BinaryTreeNode<T> Parent { get; set; }

        public BinaryTreeNode<T> LeftChild { get; set; }

        public BinaryTreeNode<T> RightChild { get; set; }

        public BinaryTreeNode<T> Min
        {
            get
            {
                var curr = this;
                while (curr != null && curr.LeftChild != null)
                {
                    curr = curr.LeftChild;
                }
                return curr;
            }
        }

        public BinaryTreeNode<T> Max
        {
            get
            {
                var curr = this;
                while (curr != null && curr.RightChild != null)
                {
                    curr = curr.RightChild;
                }
                return curr;
            }
        }


        //public BinaryTreeNode<T> RightSibling
        //{
        //    get
        //    {
        //        if (Parent == null)
        //        {
        //            return null;
        //        }

        //        if (Parent.RightChild == null)
        //        {
        //            return null;
        //        }

        //        return Parent.RightChild;
        //    }
        //}

        public BinaryTreeNode<T> Root // todo: implement set Root
        {
            get
            {
                var parent = Parent;
                while (parent != null && parent != parent.Parent)
                {
                    parent = parent.Parent;
                }
                return parent;
            }
        }

        public override string ToString()
        {
            if (Value == null)
            {
                return "null";
            }

            return Value.ToString();
        }

        public BinaryTreeNode()
        {

        }

        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public BinaryTreeNode<T> Insert(T newValue)
        {
            BinaryTreeNode<T> newNode;

            if (this.Value == null)
            {
                this.Value = newValue;
            }

            if (newValue.CompareTo(Value) < 0)
            {
                if (LeftChild == null)
                {
                    newNode = new BinaryTreeNode<T>(newValue);
                    newNode.Parent = this;
                    this.LeftChild = newNode;
                }
                else
                {
                    newNode = LeftChild.Insert(newValue);
                }
            }
            else
            {
                if (RightChild == null)
                {
                    newNode = new BinaryTreeNode<T>(newValue);
                    newNode.Parent = this;
                    this.RightChild = newNode;
                }
                else
                {
                    newNode = RightChild.Insert(newValue);
                }
            }

            return newNode;
        }
    }
}
