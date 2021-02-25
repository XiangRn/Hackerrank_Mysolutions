using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Leonardo_sPrimeFactors
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            long n = Convert.ToInt64(Console.ReadLine());long count = 0;
            List<long> prime = new List<long>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 };long index = 0;
           // List<int> not_prime = new List<int>();
          long temp = 0; long blue = 0;
            // int m = Convert.ToInt32(Console.ReadLine());         
            
            for (long j = 2; j < n; j++)
            {
                for (int i = 0; i < prime.Count; i++)
                {
                    if (j % prime[i] == 0)
                    {
                        //if (prime.IndexOf(i) > -1)
                        //{
                            temp++;
                        //}
                        //count++;
                    }
                }
                //if (count == 0)
                //{
                //    prime.Add(j);

                //}
                if (temp > 0)
                {
                    blue = Math.Max(temp, blue);
                    temp = 0;
                }
               // count = 0;
              
            }
            Console.WriteLine(blue);
            //foreach (var item in prime)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.Write("\n");

            //for (int k = 0; k < not_prime.Count; k++)
            //{
            //    Console.WriteLine("huong");
            //    while (not_prime[k] >= 2)
            //    {
            //        for (int i = 0; i < prime.Count; i++)
            //        {

            //            if (not_prime[k] % prime[i] == 0)
            //            {
            //                not_prime[k] = not_prime[k] / prime[i];

            //                index++;
            //                break;
            //            }
            //        }
            //    }
            //    not_prime.Remove(not_prime[k]);
            //    if (index > 0)
            //    {

            //        blue = Math.Max(blue, index);
            //        index = 0;
            //    }

            //}
            //Console.WriteLine(blue);
            Console.ReadLine();
        }
    }
}
