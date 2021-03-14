using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parralel
{
    class Result
    {

        /*
         * Complete the 'minTime' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY files
         *  2. INTEGER numCores
         *  3. INTEGER limit
         */

        public static long minTime(List<int> files, int numCores, int limit)
        {
            int temp = -1;
           files.Sort();
            files.Reverse();
                       long sum = 0;
          
            while (files.Count > 0 && numCores>0)
            {
                if (limit > 0)
                {
                    if (files[0] % numCores == 0)
                    {
                        sum += (files[0] / numCores);
                        limit--;
                        files.RemoveAt(0);
                        continue;
                    }
                }
                 sum += files[0];
               // Console.WriteLine("sum : "+sum);
                files.RemoveAt(0);
                   
            }
            Console.WriteLine("limit"+limit);
            return sum;
           
         
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int filesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> files = new List<int>();

            for (int i = 0; i < filesCount; i++)
            {
                int filesItem = Convert.ToInt32(Console.ReadLine().Trim());
                files.Add(filesItem);
            }

            int numCores = Convert.ToInt32(Console.ReadLine().Trim());

            int limit = Convert.ToInt32(Console.ReadLine().Trim());
            long result = Result.minTime(files, numCores, limit);
            Console.Write("\n");
         Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
