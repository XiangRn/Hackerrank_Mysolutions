using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedString
{
    class Program
    {
        static string superReducedString(string s)
        {
            List<char> s1 = s.ToList();
            int i = 0; s.ToList();
            while (s1.Count > 0 && i < s1.Count - 1 && i >= 0)
            {
                if (s1[i] == s1[i + 1])
                {
                    s1.RemoveRange(i, 2);
                    if (i != 0)
                    {
                        i--;
                    }
                    continue;
                }
                else
                {
                    i++;
                }

            }
          return s1.Count != 0 ? string.Join("", s1) : "Empty String";
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = Console.ReadLine();

            string result = superReducedString(s);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
