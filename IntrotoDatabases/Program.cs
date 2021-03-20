using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoDatabases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int N = Convert.ToInt32(Console.ReadLine());
            List<string> ds = new List<string>();
            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];

                string emailID = firstNameEmailID[1];
                if (emailID.Contains("@gmail.com"))
                {
                    if (emailID.LastIndexOf('@') > 0)
                    {
                        string m = emailID.Substring(emailID.LastIndexOf('@'), 10);
                        
                        if (m == "@gmail.com")
                        {
                            ds.Add(firstName);
                        }
                    }
                }
               
            }
            ds.Sort();
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
