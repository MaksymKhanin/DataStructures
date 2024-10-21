using System;

namespace DataStructures
{
    internal class Node<T>
    {
        internal T Data { get; set; }
        internal Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
    class LinkedList<T>
    {
        Node<T> Head { get; set; }

        void AddFirst(T data)
        {
            var node = new Node<T>(data);
            node.Next = Head;
            Head = node;
        }

        internal void AddLast(T data)
        {
            var node = new Node<T>(data);

            if (Head == null)
            {
                Head = node;
                return;
            }
            var last = GetLast();
            last.Next = node;
        }

        Node<T> GetLast()
        {
            var temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }

        internal void Print()
        {
            var temp = Head;
            while(temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }

        internal void Swap<T>(T x, T y)
        {
            if (x.Equals(y))
                return;

            Node<T> PrevX = null;
            var CurrX = Head;

            while (CurrX.Next != null && !CurrX.Data.Equals(x))
            {
                PrevX = (Node<T>)(object)CurrX;
                CurrX = CurrX.Next;
            }

            Node<T> PrevY = null;
            var CurrY = Head;

            while (CurrY.Next != null && !CurrY.Data.Equals(y))
            {
                PrevY = (Node<T>)(object)CurrY;
                CurrY = CurrY.Next;
            }

            if (CurrX == null || CurrY == null)
            {
                return;
            }

            // found x and y

            if (PrevX != null)
            {
                PrevX.Next = (Node<T>)(object)CurrY;
            }
            else Head = CurrY;

            if (PrevY != null)
            {
                PrevY.Next = (Node<T>)(object)CurrX;
            }
            else Head = CurrX;

            var temp = CurrX.Next;
            CurrX.Next = CurrY.Next;
            CurrY.Next = temp;
        }

    }
}
