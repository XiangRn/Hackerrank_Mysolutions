using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairWithTwoPointers
{
    class Program
    {
       static int hasPairWithTarget(int[] arr, int n, int target)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
          
            int[] arr = new int[] { -2, -1, 5, 13, 17, 25, 40 };
            Console.WriteLine("Nhập target : ");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập item của array : ");
           
           
            Console.WriteLine(hasPairWithTarget(arr,arr.Length,target));
            Console.ReadLine();
        }
    }
}
