using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangrams
{
    class Program
    {
        static string pangrams(string s)
        {
            string origin = "abcdefghijklmnopqrstuvwxyz";
           
            int count = 0;
            for (int i = 0; i < origin.Length; i++)
            {
                if (!s.Contains(origin[i]))
                {
                    count++;

                }
            }

            if (count > 0)
            {
               return "not pangram";

            }
            else
            {
              return "pangram";
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = Console.ReadLine().ToLower();
            string result = pangrams(s);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
