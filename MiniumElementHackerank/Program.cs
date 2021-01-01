using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniumElementHackerank
{
    
    class Program
    {
        static int MinimumElement(int[] a, int n)
        {         
            if (n <2)
            {
                return a[0];
            }
            else
            {                
                if (a[0] > a[1])
                {
                    
                    a = a.Where(val => val != a[0]).ToArray();
                }
                else
                {
                    a = a.Where(val => val != a[1]).ToArray();
                }
                return MinimumElement(a, n - 1);
            }      
                
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
       
            Console.Write("\n");
            Console.WriteLine(MinimumElement(new int [] { 7, 4, 9, 5, 2 }, 5));
            // int index = arr[0];
            //for (int i = 0; i < n; i++)
            //{

            //    if (index > arr[i])
            //    {
            //        index = arr[i];
            //    }

            //}
            //int k = Convert.ToInt32(Console.ReadLine());
            //arr = arr.Where(val => val != k).ToArray();
            //foreach (int i in arr)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.Write("\t");
            // Console.WriteLine(index);
            long t = nanoTime();
            Console.ReadLine();
        }
       
    }
    
  
}
