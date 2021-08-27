using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulTriplets
{
    class Program
    {
        public static int beautifulTriplets(int d, List<int> a)
        {
            List<int> lst = new List<int>(); int count = 0;
            for (int i = 0; i < a.Count; i++)
            {
                int j = i;
                for (; j < a.Count;)
                {
                    int k = a.IndexOf(a[j] + d);
                    if (k > j)
                    {
                        if (a.Count(x => x == a[j]) > 1)
                        {
                            a.ToList().RemoveAt(j);
                        }
                        lst.Add(a[j]);
                        lst.Add(a[k]);

                        if (lst.Distinct().ToList().Count == 3)
                        {
                            count++;
                            break;
                        }
                        j = k;
                    }
                    else
                    {
                        break;
                    }
                }
                lst.Clear();
            }
           return count;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int d = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(beautifulTriplets(d,a.ToList()));
            Console.ReadLine();
        }
    }
}
