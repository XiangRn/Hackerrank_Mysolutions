using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLoveLetterMystery
{
    class Program
    {
        public static int theLoveLetterMystery(string s)
        {
            char[] arr = s.ToCharArray(); int sum = 0;
            if (CheckPalindrome(s))
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    if (arr[i] != arr[arr.Length - 1 - i])
                    {
                        if (arr[i].CompareTo(arr[arr.Length - 1 - i]) < 0)
                        {
                            sum += Math.Abs(arr[i].CompareTo(arr[arr.Length - 1 - i]));
                            arr[arr.Length - 1 - i] = arr[i];

                        }
                        else
                        {
                            sum += Math.Abs(arr[i].CompareTo(arr[arr.Length - 1 - i]));
                            arr[i] = arr[arr.Length - 1 - i];
                        }
                    }
                }
               return sum;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
          
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = theLoveLetterMystery(s);

                Console.WriteLine(result);
            }

            Console.ReadLine();
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
    }
}
