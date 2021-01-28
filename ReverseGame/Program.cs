using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseGame
{
    class Program
    {
        static int Reverse_Game(int N, int K)
        {
            return K < N / 2 ? 2 * K + 1 : 2 * (N - K - 1);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int t = Convert.ToInt32(Console.ReadLine());


            for (int j = 0; j < t; j++)
            {
                string[] nk = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);
                Console.WriteLine(Reverse_Game(n, k));
            }


            Console.ReadLine();
        }
    }
}
