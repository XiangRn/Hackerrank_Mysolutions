using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesbyMatch
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
             int sum = 0;
            while (ar.Length > 0)
            {
                int count = 1;
                for (int j = 1; j < ar.Length; j++)
                {
                    if (ar.ElementAt(0) == ar[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {            
                    sum += count / 2;
                
                }
                ar = ar.Where(e => e != ar.ElementAt(0)).ToArray();

            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine());
       // int[] a = new int[n];// int sum = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //while(a.Length>0)
            // {
            //     int count = 1;
            //     for (int j = 1; j < a.Length; j++)
            //     {

            //         if(a.ElementAt(0)==a[j])
            //         {
            //             count++;
            //         }    
            //     }
            //     if (count > 1)
            //     {
            //         Console.WriteLine("count "+count);
            //         sum += count / 2 ;
            //         Console.WriteLine("sum: "+sum);

            //     }
            //     a = a.Where(e => e != a.ElementAt(0)).ToArray();

            // }
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
      ;
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
