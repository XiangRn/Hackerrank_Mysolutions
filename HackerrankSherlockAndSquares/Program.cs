using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSherlockAndSquares
{
    class Program
    {
        static int squares(int a, int b)
        {
            int i = 0; int count = 0;
            while (true)
            {

                if (Math.Pow(i, 2) >= a && Math.Pow(i, 2) <= b)
                {

                    count++;
                }

                i++;
                if (Math.Pow(i, 2) > b)
                {
                    break;
                }
            }
            return count;

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] ab = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(ab[0]);

                int b = Convert.ToInt32(ab[1]);

                int result = squares(a, b);

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
