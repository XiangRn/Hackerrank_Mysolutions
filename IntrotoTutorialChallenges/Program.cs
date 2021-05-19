using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoTutorialChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int>();
            for (int i = 0; i < n; i++)
            {
                arr.Add(Convert.ToInt32(Console.ReadLine()));
            }
            arr.Sort();
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(arr.IndexOf(v));
            Console.ReadLine();
        }
    }
}
