using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMICPCTeam
{
    class Program
    {
        static int[] acmTeam(string[] topic)
        {
            List<int> kq = new List<int>();
            int count = topic[0].Length; int blue = 0;
                 
            for (int i = 0; i < topic.Length; i++)
            {
                for (int j = i + 1; j < topic.Length; j++)
                {
                    for (int k = 0; k < topic[i].Length; k++)
                    {

                        if (topic[i][k]=='0'&& topic[j][k]=='0')
                        {                          
                            count--;
                        }
                    }
                        blue = Math.Max(blue, count);
                        kq.Add(count);
                        count = topic[i].Length;  
                }
            }
            count = 0;
            foreach (var item in kq)
            {
                if (blue == item)
                {
                    count++;
                }
            }
            int[] rs = new int[2] { blue, count };
            return rs;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            string[] topic = new string[n];

            for (int i = 0; i < n; i++)
            {
                string topicItem = Console.ReadLine();
                topic[i] = topicItem;
            }

            int[] result = acmTeam(topic);

            Console.WriteLine(string.Join("\n", result));

            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //int count = m;int blue = 0;
            //string[] a = new string[n];
            //List<int> kq = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = Console.ReadLine();
            //}

            //Console.Write("\n");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i+1; j < n; j++)
            //    {
            //        for (int k = 0; k < m; k++)
            //        {

            //            if (Convert.ToInt32(a[i][k].ToString()) + Convert.ToInt32(a[j][k].ToString()) == 0)
            //            {

            //                count--;
            //            }
            //        }
            //        blue = Math.Max(blue, count);
            //        kq.Add(count);
            //        count = m;

            //    }
            //}count = 0;
            //foreach (var item in kq)
            //{
            //    if (blue == item)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(blue);
            //Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
