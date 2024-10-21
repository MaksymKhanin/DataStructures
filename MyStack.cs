using System.Collections;

namespace DataStructures
{
    internal class MyStack
    {
        Stack mainStack;
        Stack minStack;

        
        void Push(int x)
        {
            if(mainStack.Count == 0 || x <(int) minStack.Peek())
            {
                minStack.Push(x);
            }
            mainStack.Push(x);
        }

        void Pop()
        {
            if(minStack == mainStack)
            {
                minStack.Pop();
            }
            mainStack.Pop();
        }

        void GetMin()
        {
            minStack.Peek();
        }
    }
}
