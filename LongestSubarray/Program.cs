using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;        
            int max = 0;
            List<int> ls = new List<int>() { 1,1,3,3,2,2,7,7,6,6,6,8,8 };
            List<int> ls2 = new List<int>();
                     int i=0;int j;
          while(ls.Count>0&&i<ls.Count-1)
            {
                ls2.Add(ls[i]);
                for ( j = i+1; j <ls.Count; j++)
                {
                    if (Math.Abs(ls[i] - ls[j]) == 1)
                    {
                        if (ls2.Count < 2)
                        {
                            ls2.Add(ls[j]);
                            if (j == ls.Count - 1)
                            {
                                max = Math.Max(max, (j - i + 1));
                                break;
                            } continue;
                        }
                        if(ls2.Count==2 && ls2.Contains(ls[j]))
                        {
                            if (j == ls.Count - 1)
                            {
                                max = Math.Max(max, (j - i+1));
                                break;
                            } continue;
                        }
                        else
                        {
                            max = Math.Max(max, (j - i));
                            break;
                        }
                    }
                    if(Math.Abs(ls[i] - ls[j]) == 0)
                    {
                        continue;
                    }
                   if(Math.Abs(ls[i] - ls[j]) > 1)
                    {
                        if (ls2.Count == 2)
                        {
                            max = Math.Max(max, (j - i));
                        } break;
                    }    
                }          
                ls2.Clear();
                i++;
            }
 
            Console.WriteLine(max);

            Console.ReadLine();
        }
    }
}
