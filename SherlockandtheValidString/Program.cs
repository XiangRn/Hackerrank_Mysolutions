using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockandtheValidString
{
    class Program
    {
        public static string isValid(string s)
        {          
            List<char> sf = new List<char>();            
            for (int i = 0; i < s.Length; i++)
            {
                if (!sf.Contains(s[i]))
                {
                    sf.Add(s[i]);
                   
                }
            }
            Dictionary<char, int> lst = new Dictionary<char, int>();
            foreach (var item in sf)
            {
                int count = s.Count(x => x == item);
                if (!lst.ContainsKey(item))
                {
                    lst.Add(item, count);
                }
            }
            Dictionary<int, int> lst2 = new Dictionary<int, int>();         
            foreach (var item in lst)
            {
                if (!lst2.ContainsKey(item.Value))
                {
                    int count = lst.Count(x => x.Value == item.Value);
                    
                        lst2.Add(item.Value, count);
                }
            }
            if (lst2.Count == 2)
            {
                if ((lst2.ElementAt(0).Key == 1 && lst2.ElementAt(0).Value == 1) || (lst2.ElementAt(1).Key == 1 && lst2.ElementAt(1).Value == 1))
                {
                    return "YES";
                }
                else if (Math.Abs(lst2.ElementAt(0).Key - lst2.ElementAt(1).Key) == 1 && lst2[Math.Max(lst2.ElementAt(0).Key, lst2.ElementAt(1).Key)] == 1)
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }
            else if (lst2.Count == 1)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = Console.ReadLine();
            Console.WriteLine(isValid(s));
            Console.ReadLine();
        }
    }
}
