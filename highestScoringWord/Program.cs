using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highestScoringWord
{
    class Program
    {
        static string HighScoringWord(string x)
        {
            string[] xs = x.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] ds = new int[xs.Length];
            for (int i = 0; i < xs.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < xs[i].Length; j++)
                {
                    sum += (Math.Abs(xs[i][j].CompareTo('a')) + 1);
                }
                ds[i] = sum;
            }

            int index = Array.IndexOf(ds, ds.Max());
            return xs[index];
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string x = Console.ReadLine();
            Console.WriteLine(HighScoringWord(x));
            Console.ReadLine();
        }
    }
}
