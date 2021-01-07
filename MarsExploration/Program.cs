using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExploration
{
    class Program
    {
        static int marsExploration(string s)
        {
             int count = 0;
            if (s.Length <= 0)
            {
                return 0;
            }
            else
            {
                if (s[0] != 'S')
                {
                    count++;
                }
                if (s[1] != 'O')
                {
                    count++;
                }
                if (s[2] != 'S')
                {
                    count++;
                }
                s = s.Substring(3, s.Length - 3);
                return count + marsExploration(s);
            }
           
           

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = Console.ReadLine();

            Console.WriteLine(marsExploration(s));
            Console.ReadLine();
        }
    }
}
