using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Result
    {
        static int countingValleys(int steps, string path)
        {
            int sum = 0; int count = 0;

            foreach (var item in path)
            {
                if (item == 'U')
                {
                    sum += 1;
                    if (sum == 0)
                    {
                        if (item == 'U')
                        {
                            count++;
                        }
                    }
                }
                if (item == 'D')
                {
                    sum -= 1;
                }

            }
            return count;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = Result.countingValleys(steps, path);

           Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
