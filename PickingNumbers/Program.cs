using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> arr_int = new List<int>() { 1,1,2,2,4,4,5,5};
            List<int> arr_copy = arr_int;
            int result = 0;
            arr_copy.Sort();
            arr_copy.Reverse();
            int blue = 0;
            for (int i = 0; i < arr_copy.Count-1; i++)
            {
                int m = arr_copy[i]; 
                for (int j = i+1; j < arr_copy.Count;  j++)
                {
                    if(Math.Abs(m - arr_copy[j]) == 1)
                    {                               
                        result += (arr_copy.Count(x => x == m));
                        result += (arr_copy.Count(x => x == arr_copy[j]));
                        break;
                    }
                    if (Math.Abs(m - arr_copy[j]) == 0)
                    {
                        result += (arr_copy.Count(x => x == m));                        
                        break;
                    }
                }
               
                blue = Math.Max(blue, result);
                result = 0;
            }
            Console.WriteLine(blue);
            Console.ReadLine();
        }
    }
}
