using System;
using System.Collections.Generic;

namespace BackSpaceStringCompare
{
    class Program
    {
        public static bool BackSpaceStringCompare(string S, string T)
        {
            char[] charS = S.ToCharArray();
            char[] charT = T.ToCharArray();

            Stack<char> S1 = new Stack<char>();
            Stack<char> T1 = new Stack<char>();

            for(int i = 0; i < S.Length; i++)
            {
                if(charS[i] != '#')
                {
                    S1.Push(charS[i]);
                }
                else if(S1.Count != 0)
                {
                    S1.Pop();
                }
            }

            for (int i = 0; i < T.Length; i++)
            {
                if (charT[i] != '#')
                {
                    T1.Push(charT[i]);
                }
                else if (T1.Count != 0)
                {
                    T1.Pop();
                }
            }

            while (S1.Count != 0 && T1.Count != 0)
            {
                char c1 = S1.Pop();
                char c2 = T1.Pop();

                if(c1 != c2)
                {
                    return false;
                }
            }

            if(S1.Count != 0 || T1.Count != 0)
            {
                return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            string S = "ac#c";
            string T = "ad#c";
            bool b = BackSpaceStringCompare(S, T);
            Console.WriteLine(b);
        }
    }
}
