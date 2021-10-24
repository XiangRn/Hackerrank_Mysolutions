using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] strings = new string[] {"abcde","sdaklfj","asdjf","na","basdn","sdaklfj","asdjf","na","asdjf","na","basdn","sdaklfj","asdjf"};
            string[] queries = new string[] {"abcde","sdaklfj","asdjf","na","basdn" };
            List<int> results = new List<int>();
            foreach (var item in queries)
            {
                int count = strings.Count(x => x == item);
                results.Add(count);
            }
            foreach (var item in results)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }
    }
}
