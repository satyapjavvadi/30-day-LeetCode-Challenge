using System;

namespace ValidParenthesisString
{
    class Program
    {
        public static bool CheckValidString(string s)
        {
            char[] ch = s.ToCharArray();
            int balance = 0;

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == ')')
                {
                    balance--;
                }
                else
                {
                    balance++;
                }

                if (balance < 0)
                {
                    return false;
                }
            }

            if (balance == 0)
            {
                return true;
            }

            balance = 0;

            for (int i = ch.Length - 1; i >= 0; i--)
            {
                if (ch[i] == '(')
                {
                    balance--;
                }
                else
                {
                    balance++;
                }

                if (balance < 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string s = "(*)";
            bool b = CheckValidString(s);
            Console.WriteLine(b);
        }
    }
}
