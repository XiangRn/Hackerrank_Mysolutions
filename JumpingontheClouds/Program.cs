using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingontheClouds
{
    class Program
    {
        public static int jumpingOnClouds(List<int> c)
        {
            int j = 0; int count = -1;
            while (j < c.Count)
            {
                if (c[j] == 1)
                {
                    j--;
                    continue;
                }
                if (c[c.Count-2]==0&&c[c.Count-1]==0 &&j==c.Count-2)
                {
                    j++;
                    count++;
                }
                else
                {
                    count++; j += 2;
                }
              
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
