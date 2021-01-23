using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace ModifiedKaprekarNumbers
{
    class Program
    {
        static void kaprekarNumbers(int p, int q)
        {
            List<long> listOfInts = new List<long>(); string m1 = string.Empty; string m2 = string.Empty;
            long num = 0;
            int temp = 0;
            while (p <= q)
            {
                num = (long)Math.Pow(p, 2);
                while (num > 0)
                {

                    listOfInts.Add(num % 10);
                    num = num / 10;                
                }
                listOfInts.Reverse();

                if (listOfInts.Count < 2)
                {
                    if (listOfInts[0] == p)
                    {
                        Console.Write(p+" "); temp++;
                    }
                }
                else
                {
                    if (listOfInts.Count % 2 == 0)
                    {
                        for (int i = 0; i < listOfInts.Count / 2; i++)
                        {
                            m1 += listOfInts[i].ToString();
                        }
                        for (int i = listOfInts.Count / 2; i < listOfInts.Count; i++)
                        {
                            m2 += listOfInts[i].ToString();
                        }
                        if ((long)Convert.ToInt64(m1) != 0 && (long)Convert.ToInt64(m2) != 0)
                        {
                            if ((long)Convert.ToInt64(m1) + (long)Convert.ToInt64(m2) == p)
                            {
                                Console.Write(p + " "); temp++;
                            }
                            else
                            {
                                while ((long)Convert.ToInt64(m1) % 10 == 0)
                                {
                                    m1 = ((long)Convert.ToInt64(m1) / 10).ToString();
                                }
                                if ((long)Convert.ToInt64(m1) + (long)Convert.ToInt64(m2) == p)
                                {
                                    Console.Write(p + " "); temp++;
                                }
                            }
                        }
                    }
                    else
                    {
                        int count = 0;
                        count = (listOfInts.Count - 1) / 2;
                        for (int i = 0; i < count; i++)
                        {
                            m1 += listOfInts[i].ToString();
                        }
                        for (int i = count; i < listOfInts.Count; i++)
                        {
                            m2 += listOfInts[i].ToString();
                        }

                        if ((long)Convert.ToInt64(m1) + (long)Convert.ToInt64(m2) == p && ((long)Convert.ToInt64(m1) != 0 && (long)Convert.ToInt64(m2) != 0))
                        {
                            Console.Write(p + " "); temp++;
                        }
                        else
                        {
                            m1 = string.Empty; m2 = string.Empty;
                            count = (listOfInts.Count + 1) / 2;
                            for (int i = 0; i < count; i++)
                            {
                                m1 += listOfInts[i].ToString();
                            }
                            for (int i = count; i < listOfInts.Count; i++)
                            {
                                m2 += listOfInts[i].ToString();
                            }
                            if ((long)Convert.ToInt64(m1) + (long)Convert.ToInt64(m2) == p && ((long)Convert.ToInt64(m1) != 0 && (long)Convert.ToInt64(m2) != 0))
                            {
                                Console.Write(p + " "); temp++;
                            }                         
                        }
                    }
                    m1 = string.Empty; m2 = string.Empty;
                }
                p++; listOfInts.Clear();
            }
            if (temp == 0)
            {
                Console.WriteLine("INVALID RANGE");
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
           int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());

            kaprekarNumbers(p, q);
            Console.ReadLine();
        }
    }
}
