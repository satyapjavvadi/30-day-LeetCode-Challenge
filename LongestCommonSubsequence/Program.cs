using System;

namespace LongestCommonSubsequence
{
    class Program
    {
        public static int LongestCommonSubseq(string text1, string text2)
        {

            char[] ch1 = text1.ToCharArray();
            char[] ch2 = text2.ToCharArray();
            int n1 = ch1.Length;
            int n2 = ch2.Length;
            int[,] LCS = new int[n1 + 1, n2 + 1];


            for (int i = 1; i <= ch1.Length; i++)
            {
                for (int j = 1; j <= ch2.Length; j++)
                {
                    if (ch1[i - 1] == ch2[j - 1])
                    {
                        LCS[i, j] = LCS[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        LCS[i, j] = Math.Max(LCS[i - 1, j], LCS[i, j - 1]);
                    }
                }
            }

            return LCS[n1, n2];

        }
        static void Main(string[] args)
        {
            string text1 = "abcde";
            string text2 = "ace";
            LongestCommonSubseq(text1, text2);
        }
    }
}
