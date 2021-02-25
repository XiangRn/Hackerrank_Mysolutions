using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayoftheProgrammer
{
    class Program
    {
        static string dayOfProgrammer(int year)
        {
            List<int> months; int sum = 0;
            if (year>=1700 && year < 1918)
            {
                months = new List<int>() { 31, 31, 30, 31, 30, 31, 31 };
                if (year % 4 == 0)
                {
                    months.Insert(1, 29);
                }
                else
                {
                    months.Insert(1, 28);
                }           
            }
            else if (year == 1918)
            {
                months = new List<int>() { 32, 31, 30, 31, 30, 31, 31 }; months.Insert(1, 28-14);                           
            }
            else
            {
                months = new List<int>() { 31, 31, 30, 31, 30, 31, 31 };
                if (year % 400 == 0 || (year % 4 == 0) && (year % 100 != 0))
                {
                    months.Insert(1, 29);
                }
                else
                {
                    months.Insert(1, 28);
                }                           
            }
            foreach (var item in months)
            {
                sum += item;
            }
            int day = 256 - sum;
            return day + ".0" + (months.Count + 1) + "." + year;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = dayOfProgrammer(year);

           Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
