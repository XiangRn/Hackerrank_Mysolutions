using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortPart1
{
    class Program
    {
        static void insertionSort1(int n, int[] arr)
        {
            for (int i =1 ; i < n; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while ((j>=0)&&temp < arr[j] )
                {
                   
                    arr[j + 1] = arr[j];
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write(arr[k] +" " );
                    }
                    j--;
                    Console.Write("\n");
                }
                arr[j + 1] = temp;
            }
            for (int k = 0; k < n; k++)
            {
                Console.Write(arr[k] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            insertionSort1(n,arr);
            Console.ReadLine();

        }
    }
}
