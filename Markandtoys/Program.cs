using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markandtoys
{
    class Program
    {
        static int maximumToys(int[] prices, int k)
        {

            Array.Sort(prices);
            int count = 0, S = 0, index = 0; int[] c = new int[prices.Length];
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i; j < prices.Length; j++)
                {
                    S += prices[j]; count++;
                  
                    if (S > k)
                    {
                        S -= prices[j]; count--;
                        break;
                    }
                }
                if (count > 0)
                {
                    c[index] = count;
                    count = 0; S = 0;
                    index++;
                }
            }
            
            Array.Sort(c); Array.Reverse(c);
            return c[0];
        }

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);
            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
 ;
         
            Console.WriteLine(maximumToys(prices,k));
            Console.ReadLine();
        }
    }
}
