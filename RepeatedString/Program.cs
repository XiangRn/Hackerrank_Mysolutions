using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        public static long repeatedString(string s, long n)
        {
            int numberofa = s.Count(x => x == 'a');
            long spairs = n / s.Length;
            long m = n % (s.Length);
            string s1 = string.Empty;
            if (m > 0)
            {
                s1 = s.Substring(0, (int)m);
            }
            long totalofa = spairs * numberofa + s1.Count(x => x == 'a');
            return totalofa;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = repeatedString(s, n);

            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
