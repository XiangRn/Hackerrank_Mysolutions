using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIndex
{
    class Program
    {
        public static int palindromeIndex(string s)
        {
            int i = 0;
            while (i < s.Length/2)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    if (CheckPalindrome(s.Remove(i, 1)))
                    {
                        return i;
                    }
                    if (CheckPalindrome(s.Remove(s.Length - 1 - i, 1)))
                    {
                        return s.Length - 1 - i;
                    }
                }
                i++;
            }
            return -1;
        }
        private static bool CheckPalindrome(string s)
        {
            var middle = s.Length / 2;
            int i = 0;
            while (i < middle)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
                i++;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = palindromeIndex(s);

                Console.WriteLine(result);
                //Console.WriteLine(result);
            }
            //Console.WriteLine(CheckPalindrome(Console.ReadLine())?"Palindrome":"Not Palindrome");
            Console.ReadLine();
        }
       
    }
}
