using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flipColor
{
    class Program
    {
        static int[] FlipColor(int[] color, int[] t)
        {
            Array.Sort(t);
            for (int i = 0; i < t.Length; i++)
            {
                if(color.Length - t[i] > 0)
                {
                    int[] target = new int[color.Length - t[i]];
                    Array.Copy(color, t[i], target, 0, color.Length - t[i]);
                    for (int j = t[i]; j < (color.Length-1+t[i])/2; j++)
                    {
                        if (color[j] == color[color.Length - 1 - j])
                        {
                            if (color[j] == 1)
                            {
                                color[j] = color[color.Length - 1 - j]=0;
                            }
                            else
                            {
                                color[j] = color[target.Length - 1 - j] = 1;
                            }
                        }
                        else
                        {
                            if (color[j] == 1)
                            {
                                color[j] = 0;
                                color[color.Length - 1 - j] = 1;
                            }
                            else
                            {
                                color[j] = 1;
                                color[color.Length - 1 - j] = 0;
                            }
                        }
                    }
                    if ((color.Length-1+t[i]) % 2 != 0)
                    {
                        if (color[(target.Length-1)/2] == 1)
                        {
                            target[(target.Length - 1) / 2] = 0;
                           
                        }
                        else
                        {
                            target[(target.Length - 1) / 2] = 1;
                            
                        }
                    }
                    Array.Copy(target, 0, color, t[i], color.Length - t[i]);
                }
                
                //  target=target.Select(x=>x==1?x=0:x=1).ToArray();
            
              
            }
            return color;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] color = new int[] { 0, 1, 1, 1, 0, 0 };
            int[] t = new int[] { 0, 0, 2, 0, 1, 4, 1, 2, 1 };
           
            foreach (var item in FlipColor(color,t))
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }
    }
}
