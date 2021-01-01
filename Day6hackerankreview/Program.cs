using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6hackerankreview
{
    class Program
    {
        //cách 1
        static void C1()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] m = new string[n];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = Console.ReadLine();
            }

            for (int i = 0; i < m.Length; i++)
            {
                char[] k = new char[m[i].Length / 2]; int index = 0;
                char[] k1 = new char[m[i].Length / 2 + 1]; int index1 = 0;
                for (int j = 0; j < m[i].Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        k[index] = m[i][j];
                        index++;
                    }
                    else
                    {

                        k1[index1] = m[i][j];
                        index1++;
                    }
                }
                string str1 = string.Join("", k);
                string str2 = string.Join("", k1);
                Console.WriteLine(str1 + " " + str2);
            }
        }
        static void C2()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string[] m = new string[n];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = Console.ReadLine();



                for (int j = 0; j < m[i].Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(m[i][j]);
                    }
                }
                Console.Write(" ");
                for (int j = 0; j < m[i].Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write(m[i][j]);
                    }
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToInt32('A'));
                Console.ReadLine();
        }
    }
}
