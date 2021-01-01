using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int m = 0;
            for (int i = 0; i < candles.Count; i++)
            {
                if (m < candles[i])
                {
                    m = candles[i];
                }
            }
            int count = 0;
            for (int i = 0; i < candles.Count; i++)
            {
                if (m == candles[i])
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
         
        
        Console.WriteLine(birthdayCakeCandles(candles));
            //int m = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (m < a[i])
            //    {
            //        m = a[i];
            //    }
            //}
            //int count = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (m == a[i])
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("Số lớn nhất " + m);
            //Console.WriteLine("Tổng cộng có " + count + " lớn nhất");
            Console.ReadLine();
        }
    }
}
