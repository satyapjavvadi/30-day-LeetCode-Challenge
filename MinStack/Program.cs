using System;
using System.Collections;
using System.Collections.Generic;

namespace MinStack
{
    public class MinStack
    {

        /** initialize your data structure here. */

        Stack<int> S = new Stack<int>();
        Stack<int> min_Stack = new Stack<int>();


        public MinStack()
        {
        }

        public void Push(int x)
        {

            S.Push(x);

            if (min_Stack.Count == 0 || min_Stack.Peek() >= x)
            {
                min_Stack.Push(x);
            }

        }

        public void Pop()
        {
            var item = 0;
            if (S.Count != 0)
            {
                item = S.Pop();
            }
            if (item == min_Stack.Peek())
            {
                min_Stack.Pop();
            }

        }

        public int Top()
        {
            if (S.Count != 0)
            {
                return S.Peek();
            }
            return 0;

        }

        public int GetMin()
        {
            if (min_Stack.Count != 0)
            {
                return min_Stack.Peek();
            }
            return 0;

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            MinStack S = new MinStack();
            S.Push(-2);
            S.Push(0);
            S.GetMin();
            S.Push(-3);
            S.GetMin();
            S.Pop();
            S.GetMin();
            S.Top();
        }
    }
}
