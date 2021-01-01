using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankClimbingTheLeaderBoard
{
    class Program
    {
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {

            //   for (int i = player.Count - 1; i >= 0; i--)
            //   {
            //       if (player[i] >= ranked[0])
            //       {
            //           ds.Add(1);
            //       }
            //     else if (player[i] < ranked[ranked.Count - 1])
            //       {
            //           ds.Add(ranked.Count + 1);

            //       }
            //       else
            //       {
            //           for (int j = 0; j < ranked.Count - 1; j++)
            //           {
            //               if (player[i] < ranked[j] && player[i] >= ranked[j + 1])
            //               {
            //                   ds.Add(j + 2);
            //                   break;
            //               }

            //           }
            //       }                
            //   }           
            //ds.Reverse();
            ranked = ranked.Distinct().ToList(); List<int> ds = new List<int>();
            int i = player.Count - 1, j = 1;
            while (i > -1)
            {

                if (player[i] >= ranked[0])
                {
                    ds.Add(1); i--; continue;
                }
                else if (player[i] < ranked[ranked.Count - 1])
                {
                    ds.Add(ranked.Count + 1);i--;
                   
                }
                else if (player[i] < ranked[j - 1] && player[i] >= ranked[j])
                {
                    ds.Add(j + 1); i--;
                }
                else if(j<ranked.Count)
                {
                    j++;

                }

            }
            ds.Reverse();
            return ds;
        }
       
        

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

            List<int> result = climbingLeaderboard(ranked, player);
            Console.WriteLine(String.Join("\n", result));
            Console.ReadLine();
        }
    }
}
