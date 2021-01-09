using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankinaString
{
    class Program
    {
        static string hackerrankInString(string s)
        {
            string origin = "hackerrank";
            List<char> ls; List<int> ls1 = new List<int>(); int m = 0;
            ls = s.ToCharArray().ToList();
            if (ls.Count < origin.Length)
            {
                return "NO";
            }
            else
            {
                for (int i = 0; i < origin.Length; i++)
                {
                    m = ls.IndexOf(origin[i]);
                    if (m > -1)
                    {
                        ls1.Add(m);

                        for (int j = 0; j <= m; j++)
                        {
                            ls[j] = '.';
                        }
                    }
                }             
                if (ls1.Count < origin.Length)
                {
                   return "NO";
                }
                else
                {
                   return "YES";
                }

            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
         

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                string result = hackerrankInString(s);

                Console.WriteLine(result);
            }



            Console.ReadLine();
        }
    }
}
