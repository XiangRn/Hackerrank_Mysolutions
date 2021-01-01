using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigitsHackerrank
{
    class Program
    {
        static int findDigits(int n)
        {
            int index = 10;
            while (n / index >= 10)
            {
                index *= 10;
            }
            int k = n; int S = 0; int m = 0; List<int> a = new List<int>();
            while (true)
            {
                m = (k % index); a.Add((k / index));k = m;index /= 10;
                if (index == 1)
                {
                    a.Add(m);
                    break;
                }
            }
            int temp = 0;          
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] != 0)
                {
                    if (n % a[i] == 0)
                    {
                        temp++;
                    }
                }

            }
            return temp;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
