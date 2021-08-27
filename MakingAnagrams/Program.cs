using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnagrams
{
    class Program
    {
        public static int makingAnagrams(string s1, string s2)
        {
            List<char> lst = new List<char>();
            for (int i = 0; i < s2.Length; i++)
            {
                if (s1.Contains(s2[i]))
                {
                    lst.Add(s2[i]);
                }
            }
            foreach (var item in lst)
            {
                if (s1.Contains(item) && s2.Contains(item))
                {
                    s1 = s1.Remove(s1.IndexOf(item), 1);
                    s2 = s2.Remove(s2.IndexOf(item), 1);
                }
            }
           return (s1.Length + s2.Length);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            int result = makingAnagrams(s1, s2);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
