using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundleRaceHackerank
{
    class Program
    {
        static int hurdleRace(int k, int[] height)
        {

            int index = height[0];
            for (int i = 0; i < height.Length; i++)
            {
                if (index < height[i])
                {
                    index = Math.Max(index, height[i]);
                }
            }
            if (index - k > 0)
            {
               return index - k;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
    ;
          
            foreach (int i in height)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine("\n");
            Console.WriteLine(hurdleRace(k,height));
            Console.ReadLine();
        }
    }
}
