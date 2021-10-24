using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViralAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0; int numberofliker = 0; int numberofinviter = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    numberofliker = 5 / 2;
                }
                else
                {
                    numberofliker = numberofinviter / 2;
                }               
                 numberofinviter = numberofliker * 3;
                sum += numberofliker;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
