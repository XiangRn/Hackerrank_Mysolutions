using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockandGCD
{
    class Program
    {
        public static string solve(List<int> lst)
        {
            lst.Sort(); lst.Reverse(); int count = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                for (int j = i; j < lst.Count - 1; j++)
                {
                    if (lst[j] % lst[j + 1] != 0)
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count > 0)
            {
                
                return ("YES");
            }
            else
            {
               return ("NO");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int aCount = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

                string result = solve(a);

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
