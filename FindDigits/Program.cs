using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine()) ;
            // Console.WriteLine(n%10);
            int count = 0;
            int m = n;
            do
            {
                int k = (m % 10);
                if (k == 0)
                {
                    m = m / 10;
                    continue;
                }
                else
                {
                    if (n % (k) == 0)
                    {
                        count++;
                    }
                }

                m = m / 10;
            } while (m > 0);
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
