using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7hackerankArrays
{
    class Program
    {
        static void My_closefriend_name()
        {
            int[] arr = new int[] { 76,101,32,78,103,111,99,32,84,104,117,111,110,103};
            string n = string.Empty;
            for(int i = 0; i < arr.Length; i++)
            {
                n += (char)arr[i];
            }
            Console.WriteLine(n);
        }
        static void Check_Number()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập 1 số có 3 chữ số : "); int n = Convert.ToInt32(Console.ReadLine()); int sum=0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);

        }
        static void Two_dimensional()
        {
            Random rd = new Random();
            int[] arr = Array.ConvertAll(Console.ReadLine().ToString().Split(' '), i => Convert.ToInt32(i)) ;
            Console.WriteLine(string.Join(" ", arr));
        }
        static void Main(string[] args)
        {
            //Two_dimensional(); 
            //   My_closefriend_name();
            Check_Number();
            //int n = Convert.ToInt32(Console.ReadLine());

          //  int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
           // Array.Reverse(arr);
           //for(int i = arr.Length - 1; i >= 0; i--)
           // {
           //     Console.Write(arr[i]+" ");
           // }
          //  Console.WriteLine(string.Join(" ", arr));
            Console.ReadLine();
        }
    }
}
