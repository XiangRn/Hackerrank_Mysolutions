using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteValueSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
         
            int index = 0;
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                for (int j = 0; j <= arr.Length - 1 - i; j++)
                {
                    if (Math.Abs(arr[j]) > Math.Abs(arr[j + 1]))
                    {
                        index = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = index;
                    }
                    else if(Math.Abs(arr[j]) == Math.Abs(arr[j + 1]))
                    {
                        index = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = index;
                    }

                }
            }
            Console.WriteLine(string.Join("\n", arr));
            Console.ReadLine();
        }
    }
}
