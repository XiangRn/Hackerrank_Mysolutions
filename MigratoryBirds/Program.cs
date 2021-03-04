using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirds
{
    class Program
    {
        static int migratoryBirds(List<int> arr)
        {
            int result = 0; List<int> ls = new List<int>(); int temp = 0;
            List<int> ls1 = new List<int>(); int temp1 = 0;int n = arr.Count;
            while (arr.Count > 0)
            {
                int i = 0;int count = 1;
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    int m = Math.Max(result, count);
                    if (m > result)
                    {
                        result = m; ls.Clear();
                    }                    
                    ls.Add(arr[i]);
                    if (count < m)
                    {
                        ls.Remove(arr[i]);
                    }          
                    temp = ls[0];
                }
                else
                {
                    ls1.Add(arr[i]);
                    temp1 = ls1[0];
                }
                arr = arr.Where(e => e != arr[i]).ToList(); i++;
            }
            if (ls1.Count == n)
            {
                foreach (var item in ls1)
                {
                    temp1 = Math.Min(item, temp1);

                }
                return temp1;
            }
            else
            {
                foreach (var item in ls)
                {
                    
                    temp = Math.Min(item, temp);

                }
              
                return temp;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

           Console.WriteLine(result);

            //int result = 0;List<int> ls = new List<int>(); int temp = 0;
            // List<int> ls1 = new List<int>();int temp1 = 0;

            // while (arr.Count>0)
            // {
            //     int i = 0;
            //     int count = 1;
            //     for (int j = i+1; j < arr.Count; j++)
            //     {
            //         if (arr[i] == arr[j])
            //         {
            //             count++;
            //         }
            //     }
            //     if (count > 1)
            //     {
            //         int m = Math.Max(result, count);
            //         if (m > result)
            //         {
            //             result = m;
            //             ls.Clear();
            //         }

            //         ls.Add(arr[i]);

            //          temp = arr[i];

            //     }
            //     else
            //     {

            //         ls1.Add(arr[i]);
            //         temp1 = arr[i];
            //     }
            //     arr = arr.Where(e => e != arr[i]).ToList();

            //     i++;
            // }

            // if (ls1.Count == n)
            // {
            //     foreach (var item in ls1)
            //      {
            //         temp1 = Math.Min(item, temp1);

            //     }
            //     Console.WriteLine(temp1);
            // }
            // else
            // {
            //     foreach (var item in ls)
            //     {
            //         temp = Math.Min(item, temp);

            //     }
            //     Console.WriteLine(temp);
            // }

          //  Console.WriteLine(migratoryBirds(arr));
            Console.ReadLine();
        }
    }
}
