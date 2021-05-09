using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoCharacters
{
    class Program
    {
        static int alternate(string s)
        {
            string t = string.Empty;
            int result = 0;
            List<char> ls = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!ls.Contains(s[i]))
                {
                    ls.Add(s[i]);
                }
            }

            for (int i = 0; i < ls.Count - 1; i++)
            {
                for (int j = i + 1; j < ls.Count; j++)
                {
                    List<char> s1 = s.ToList();
                    s1 = s1.Where(x => x == ls[i] || x == ls[j]).ToList();
                    t = string.Join("", s1);
                  
                    if (t.Length >= 2)
                    {
                        char c0 = t[0];
                        char c1 = t[1];
                        int count = 0;
                        for (int k = 2; k < t.Length; k++)
                        {
                            if (k % 2 == 0)
                            {
                                if (t[k] == c0)
                                {
                                    count++;
                                }
                            }
                            else
                            {
                                if (t[k] == c1)
                                {
                                    count++;
                                }
                            }
                        }
                        if (count == t.Length - 2)
                        {
                            result = Math.Max(result, t.Length);
                        }

                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
         
            string s = "abaacdabd";
            Console.WriteLine(alternate(s));
            

            Console.ReadLine();
        }
      
    }
}
