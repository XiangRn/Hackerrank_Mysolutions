using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static string caesarCipher(string s, int k)
        {            
            string origin = "abcdefghijklmnopqrstuvwxyz";
            if (k > origin.Length)
            {
                k = k % 26;
            }
            char[] end = new char[origin.Length];origin.CopyTo(k, end, 0, origin.Length - k);
            origin.CopyTo(0, end, origin.Length - k, k);string rolated = string.Join("", end);
            char[] new_s = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < origin.Length; j++)
                {
                    if (char.ToLower(s[i]) == origin[j])
                    {
                        if (char.IsUpper(s[i]))
                        {
                            new_s[i] = char.ToUpper(rolated[j]);
                        }
                        else
                        {
                            new_s[i] = rolated[j];
                        }
                        count++;break;
                    }
                }
                if (count == 0)
                {
                    new_s[i] = s[i];
                }
            }
            return string.Join("", new_s);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = caesarCipher(s, k);

            Console.WriteLine(result);
            
            Console.ReadLine();
        }
    }
}
