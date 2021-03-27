using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenTwoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
      
            int[] a = new int[] { 51 }; int[] b = new int[] { 50}; int count;
            Array.Sort(a);Array.Sort(b);List<int> ds = new List<int>();
            for (int i = a[0]; i <= b[0]/a[a.Length-1]; i++)
            {
                 count = 0;
                for (int j = 0; j < b.Length; j++)
                {
                    if (b[j] % (a[a.Length - 1]*i) == 0)
                    {
                        count++;
                    }
                }
                if (count == b.Length)
                {
                    ds.Add(a[a.Length - 1] * i);
                }
            }
            if (ds.Count == 0)
            {
                count = 0;
                for (int i = 0; i < b.Length; i++)
                {
                    if (b[0] % a[0] == 0)
                    {
                        count++;
                    }
                }
                if (count == b.Length)
                {
                    ds.Add(a[0]);
                }
            }
            if (a.Length > 1)
            {
               
                count = 0;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[a.Length - 1] % a[i] == 0)
                    {
                        count++;
                    }
                }
                if (count == (a.Length - 1))
                {
                    ds.Add(a[a.Length - 1]);
                }
                else
                {
                    count = 0;
                    for (int i = 1; i < a.Length; i++)
                    {
                        if (a[i] % a[0] == 0)
                        {
                            count++;
                        }
                    }
                    if (count == (a.Length - 1))
                    {
                        ds.Add(a[0]);
                    }
                }
            }

            foreach (var item in ds)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine(ds.Count);
            Console.ReadLine();

        }
    }
}
