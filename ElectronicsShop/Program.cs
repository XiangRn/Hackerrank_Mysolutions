using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsShop
{
    class Program
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int result = -1; 
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if ((keyboards[i] + drives[j]) <= b)
                    {
                        result = Math.Max(result, (keyboards[i] + drives[j]));                   
                    }
                
                }
            }           
            return result;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Console.WriteLine("Enter the budget : ");
            // int b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("The length of keyboards prices : ");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("The length of drives prices : ");
            // int m = Convert.ToInt32(Console.ReadLine());
            // int[] keyboards = new int[n];
            // int[] drives = new int[m];
            //// int result = 0;
            // Console.WriteLine("Enter keyboards array : ");
            // for (int i = 0; i < keyboards.Length; i++)
            // {
            //     keyboards[i] = Convert.ToInt32(Console.ReadLine()) ; 
            // }
            // Console.WriteLine("Enter drives array : ");
            // for (int i = 0; i < drives.Length; i++)
            // {
            //     drives[i] = Convert.ToInt32(Console.ReadLine());
            // }

            // Console.WriteLine(getMoneySpent(keyboards,drives,b));
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);

          Console.WriteLine(moneySpent);
            Console.ReadLine();
        }
    }
}
