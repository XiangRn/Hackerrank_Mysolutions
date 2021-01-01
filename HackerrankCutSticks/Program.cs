using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCutSticks
{
    class Program
    {
        static int[] cutTheSticks(int[] arr)
        {
            List<int> ls = new List<int>();
      
            while (arr.Length > 0)
            {
                Array.Sort(arr); ls.Add(arr.Length);
                arr = arr.Where(e => e != arr[0]).ToArray();
            }
            return ls.ToArray();

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] result = cutTheSticks(arr);

            Console.WriteLine(string.Join("\n", result));
            //var n = int.Parse(Console.ReadLine());
            //var arr_temp = Console.ReadLine().Split(' ');
            //var sticks = Array.ConvertAll(arr_temp, Int32.Parse);
            //var sortedSticks = sticks.OrderByDescending(x => x).ToList(); //LINQ sorting uses stable quick sort

            //while (n > 0)
            //{
            //    Console.WriteLine(n);
            //    var smallestStickLength = sortedSticks[n - 1];
            //    for (int i = n - 1; i >= 0; i--)
            //    {
            //        sortedSticks[i] -= smallestStickLength;
            //        if (sortedSticks[i] == 0)
            //            n--;
            //    }
            //}
            Console.ReadLine();
        }
    }
}
