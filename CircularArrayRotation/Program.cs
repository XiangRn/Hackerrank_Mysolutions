using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularArrayRotation
{
    class Program
    {
        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            for (int i = 0; i < k; i++)
            {
                a.Insert(0, a[a.Count-1]);
                a.RemoveAt(a.Count - 1);
               
            }
            List<int> results = new List<int>();
            foreach (var item in queries)
            {
                results.Add(a[item]);
            }
            return results;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            int q = Convert.ToInt32(firstMultipleInput[2]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> queries = new List<int>();

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
                queries.Add(queriesItem);
            }

            List<int> result = circularArrayRotation(a, k, queries);

            Console.WriteLine(String.Join("\n", result));
            Console.ReadLine();
        }
    }
}
