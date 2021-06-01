using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestValuePalindrome
{
    class Program
    {
        public static string highestValuePalindrome(string s, int n, int k)
        {
            int[] a = Array.ConvertAll(s.ToCharArray(), x => int.Parse(x.ToString()));
            int i = 0;

            while (k > 0 && i < s.Length / 2)
            {
                if (a[i] != a[s.Length - i - 1])
                {

                    int result = Math.Max(a[i], a[s.Length - i - 1]);
                    a[i] = result;
                    a[s.Length - i - 1] = result;
                    k--;

                }

                i++;
            }

            string m = (string.Join("", a));
            Console.WriteLine(m);
            if (CheckPalindrome(m))
            {

                if (k >= 1)
                {

                    i = 0;
                    while (k >= 1 && i < s.Length / 2)
                    {
                        int j = s.Length - i - 1;
                        int c1 = Convert.ToInt32(s[i].ToString());
                        int c2 = Convert.ToInt32(s[j].ToString());
                        if (k>=2 && a[i]==c1 &&a[j]== c2)
                        {
                            if (a[i] != 9)
                            {
                                a[i] = 9;
                                a[s.Length - i - 1] = 9;
                                k -= 2;
                            }
                        }else if(k >= 1 && (a[i] != c1 || a[j] !=c2))
                        {
                            if (a[i] != 9)
                            {
                                a[i] = 9;
                                a[s.Length - i - 1] = 9;
                                k -= 1;
                            }
                        }
                       


                        i++;
                    }
                    if (n % 2 != 0 && k > 0)
                    {
                        if (a[(n - 1) / 2] != 9)
                        {
                            a[(n - 1) / 2] = 9;
                            k--;
                        }
                    }
                    m = (string.Join("", a));
                    return m;
                }
                else
                {
                    if (n % 2 != 0 && k > 0)
                    {
                        if (a[(n - 1) / 2] != 9)
                        {
                            a[(n - 1) / 2] = 9;
                            k--;
                        }
                    }
                    m = (string.Join("", a));
                    return m;
                }
            }
            else
            {
                return "-1";
            }
        }
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
          
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            string s = Console.ReadLine();
            string result = highestValuePalindrome(s, n, k);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        private static bool CheckPalindrome(string s)
        {
            var middle = s.Length / 2;
            int i = 0;
            while (i < middle)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}
