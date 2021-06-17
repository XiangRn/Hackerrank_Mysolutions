using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConstruction
{
    class Program
    {
        public static int stringConstruction(string s)
        {
            s = string.Join("", s.ToCharArray().Distinct());
            return s.Length;
        }
        static void Main(string[] args)
        {
           // int n = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = stringConstruction(s);

                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
