using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPowerOfFour
{
    class Program
    {
        static bool IsPowerOfFour(long nums)
        {

            while (nums >= 4 && nums % 4 == 0)
            {
                    if (nums == 4)
                    {
                        return true ;
                       
                    }
                    nums = nums / 4;

                }
            return false;
          
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            long nums = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(IsPowerOfFour(nums)?"True":"False");
            Console.ReadLine();
        }
    }
}
