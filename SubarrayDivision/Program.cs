using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubarrayDivision
{
    class Program
    {
        static int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            while (s.Count >= m)
            {
                int sum = 0;
                for (int i = 0; i < m; i++)
                {
                    sum += s[i];
                }
                if (sum == d)
                {
                    count++;
                }
                s.RemoveAt(0);
            }           
          return count;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
