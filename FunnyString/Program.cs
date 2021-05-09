using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyString
{
    class Program
    {
        public static string funnyString(string s)
        {
            List<int> asciiofs = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                asciiofs.Add((char)s[i]);
            }
            List<int> absofs = new List<int>();
            for (int i = 0; i < asciiofs.Count - 1; i++)
            {
                absofs.Add(Math.Abs(asciiofs[i + 1] - asciiofs[i]));
            }
            asciiofs.Reverse();
            List<int> absofr = new List<int>();
            for (int i = 0; i < asciiofs.Count - 1; i++)
            {
                absofr.Add(Math.Abs(asciiofs[i + 1] - asciiofs[i]));
            }
            int count = 0;
            for (int i = 0; i < absofs.Count; i++)
            {
                if (absofs[i] != absofr[i])
                {
                    count++;
                }
            }
            if (count > 0)
            {
                return ("Not Funny");
            }
            else
            {
                return ("Funny");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
          // int q = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                string result = funnyString(s);

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
