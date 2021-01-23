using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_divisibleSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n] ;

            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                a[i]= Convert.ToInt32(Console.ReadLine());
            }
            List<int> ls = new List<int>();int S = 0; int count = 1;List<int> l = new List<int>();
            int S1 = 0; List<int> l1 = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                ls.Add(a[i]);
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] != a[j])
                    {
                        S = a[i] + a[j];
                        if (S % k != 0)
                        {
                            ls.Add(a[j]);
                        }
                    }
                }
                foreach (var item in ls)
                {
                    Console.Write(item+" ");
                }
                Console.Write("\n");
                //for (int e = 1; e < ls.Count; e++)
                //{
                  
                //    for (int e1 = 1; e1 < ls.Count; e1++)
                //    {
                      
                //        if (ls[e] != ls[e1])
                //        {
                //            S1 = ls[e] + ls[e1];
                //            if (S1 % k != 0)
                //            {
                //                count++;
                //            }
                //        }
                //    }
                //    Console.Write(count+1);
                //    Console.Write(" ");
                //    count = 1;


                //}
               


                Console.Write("\n");
              // l.Sort(); //l1.Add(l[l.Count - 1]);
                ls.Clear();//l.Clear();
            }
            Console.Write("\n");
      //   Console.WriteLine(l1[l1.Count-1]);
   
            Console.ReadLine();
        }
    }
}
