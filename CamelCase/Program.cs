using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = Console.ReadLine();
            List<char> s1 = s.ToList();
            int i = 0; int count = 1;
            while (s1.Count > 0 && i< s1.Count)
            {
                if (char.IsUpper(s1[i]))
                {
                    count++;
                   
                }
                i++;
                
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
