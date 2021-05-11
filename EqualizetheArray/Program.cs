using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualizetheArray
{
    class Program
    {
        public static int equalizeArray(List<int> arr)
        {
            int result = 0;int count=0;
            for (int i = 0; i < arr.Count; i++)
            {
                int m = arr.Count(x => x == arr[i]);
                if (m > 1)
                {
                    result = Math.Max(m,result);


                }
                else
                {
                    count++;
                }
                
            }
            if (count==arr.Count)
            {
                return (arr.Count - 1);
            }
            return (arr.Count -result);

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = equalizeArray(arr);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
