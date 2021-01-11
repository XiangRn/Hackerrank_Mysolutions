using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThePoints
{
    class Program
    {
        static int[] findPoint(int px, int py, int qx, int qy)
        {
            List<int> xy = new List<int>();
          
                xy.Add(2 * qx - px);
                xy.Add(2 * qy - py);
               
            
            return xy.ToArray();

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine());

            for (int nItr = 0; nItr < n; nItr++)
            {
                string[] pxPyQxQy = Console.ReadLine().Split(' ');

                int px = Convert.ToInt32(pxPyQxQy[0]);

                int py = Convert.ToInt32(pxPyQxQy[1]);

                int qx = Convert.ToInt32(pxPyQxQy[2]);

                int qy = Convert.ToInt32(pxPyQxQy[3]);

                int[] result = findPoint(px, py, qx, qy);

                Console.WriteLine(string.Join(" ", result));
            }
            Console.ReadLine();
        }
    }
}
