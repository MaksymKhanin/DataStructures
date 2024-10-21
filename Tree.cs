using System;

namespace DataStructures
{
    internal class TreeNode<T> where T : IComparable<T>
    {
        internal T Data { get; private set; }
        internal TreeNode<T> Left { get; private set; } = null!;
        internal TreeNode<T> Right { get; private set; } = null!;

        public TreeNode(T data)
        {
            Data = data;
        }

        public void Add(T data)
        {
            if (data.CompareTo(Data) < 0)
            {
                if (Left == null)
                {
                    Left = new TreeNode<T>(data);
                }
                else
                {
                    Left.Add(data);
                }
            }
            else 
            {
                if (Right == null)
                {
                    Right = new TreeNode<T>(data);
                }
                else
                {
                    Right.Add(data);
                }
            }

        }
    }

    internal class Tree<T> where T : IComparable<T> 
    {
        internal TreeNode<T> Root { get; private set; } = null!;

        internal void Add(T data)
        {
            if(Root == null)
            {
                Root = new TreeNode<T>(data);
            }
            else
            {
                Root.Add(data);
            }
        }

        internal void PrintTreeInOrder(TreeNode<T> node)
        {
            if(node is not null)
            {
                Console.WriteLine(node.Data);
                PrintTreeInOrder(node.Left);
                PrintTreeInOrder(node.Right);
            }
            else
            {
                return;
            }
        }
    }
    
}
