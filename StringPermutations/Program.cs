using System;

namespace StringPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            permute(input, 0, input.Length - 1);
            Console.Read();
        }

        static string swap(string s, int pos1, int pos2)
        {
            char temp;
            char[] charArray = s.ToCharArray();
            temp = charArray[pos1];
            charArray[pos1] = charArray[pos2];
            charArray[pos2] = temp;
            string newString = new string(charArray);
            return newString;
        }

        static void permute(string str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }
    }
}
