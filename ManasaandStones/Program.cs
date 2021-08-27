using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManasaandStones
{
    class Program
    {
        public static List<int> stones(int n, int a, int b)
        {
            int m = n - 1; int m1 = 0;
            List<int> lst = new List<int>();
            while (m > -1 && m1 < n)
            {
                lst.Add((a * m) + (m1 * b));
                m--;
                m1++;
            }
            lst.Sort();
            return lst.Distinct().ToList();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int T = Convert.ToInt32(Console.ReadLine().Trim());

            for (int TItr = 0; TItr < T; TItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int a = Convert.ToInt32(Console.ReadLine().Trim());

                int b = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> result = stones(n, a, b);

                Console.WriteLine(String.Join(" ", result));
            }
            Console.ReadLine();
        }
    }
}
