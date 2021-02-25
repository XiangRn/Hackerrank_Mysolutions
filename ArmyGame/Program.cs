using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyGame
{
    class Program
    {
        static int gameWithCells(int n, int m)
        {
            int n1 = n / 2; int m1=m/ 2;
            int n2 = (n + 1) / 2; int m2 = (m + 1) / 2;
            if(m%2==0 && n % 2 == 0)
            {
                return m1 * n1;
            }
            else if(m % 2 != 0 && n % 2 != 0)
            {
                return n2 * m2;               
            }
            else 
            {
                if(m%2==0 && n % 2 != 0)
                {
                    return n2 * m1;
                }
                    return m2 * n1;               
                
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int result = gameWithCells(n, m);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
