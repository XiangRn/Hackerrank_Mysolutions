using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    class Program
    {
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            int[] rovate1 = new int[arr.Count - d];
            Array.Copy(arr.ToArray(), d, rovate1, 0, arr.Count - d);
            int[] rovate2 = new int[d];
            Array.Copy(arr.ToArray(), 0, rovate2, 0, d);

            int[] result = new int[arr.Count];
            Array.Copy(rovate1, 0, result, 0, rovate1.Length);
            Array.Copy(rovate2, 0, result, rovate1.Length, rovate2.Length);
            return result.ToList();
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = rotateLeft(d, arr);

            Console.WriteLine(String.Join(" ", result));

            Console.ReadLine();
        }
    }
}
