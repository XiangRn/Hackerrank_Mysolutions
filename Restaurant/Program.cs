using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        static int restaurant(int l, int b)
        {
            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();
            for (int i = 1; i <= l; i++)
            {
                if (l % i == 0)
                {
                    l1.Add(i);
                }
            }
            for (int i = 1; i <= b; i++)
            {
                if (b % i == 0)
                {
                    l1.Add(i);
                }
            }
            for (int i = 0; i < l1.Count; i++)
            {
                for (int j = 0; j < l1.Count; j++)
                {
                    if (i != j)
                    {
                        if (l1[i] == l1[j])
                        {
                            l2.Add(l1[i]);

                        }
                    }
                }
                l2.Sort();
            }            
            return (l * b) / Convert.ToInt32(Math.Pow((l2[l2.Count - 1]), 2).ToString());
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] lb = Console.ReadLine().Split(' ');

                int l = Convert.ToInt32(lb[0]);

                int b = Convert.ToInt32(lb[1]);

                int result = restaurant(l, b);

                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
