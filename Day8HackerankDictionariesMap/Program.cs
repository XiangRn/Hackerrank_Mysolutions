using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8HackerankDictionariesMap
{
    class Program
    {
     static Dictionary<string, string> contact = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = s[0]; string phone = s[1];
                contact.Add(name, phone);
            }
            while (true)
            {
                string kt = Console.ReadLine(); 
                if (string.IsNullOrEmpty(kt))
                {
                    break;
                }
                else
                {                 
                    if (contact.ContainsKey(kt))
                        {
                            Console.WriteLine(kt + "=" + contact[kt]);
                        }
                        else
                        {
                        Console.WriteLine("Not found");
                        }                  
                }
            };



            //int n = int.Parse(Console.ReadLine());
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            //for (int i = 0; i < n; i++)
            //{
            //    var names = Console.ReadLine().Split(' ');
            //    phoneBook.Add(names[0], names[1]);
            //}

            //string name = Console.ReadLine();
            //do
            //{
            //    string printValue = "Not found";
            //    if (phoneBook.ContainsKey(name))
            //    {
            //        printValue = name + "=" + phoneBook[name];
            //    }

            //    Console.WriteLine(printValue);

            //    name = Console.ReadLine();

            //} while (!string.IsNullOrEmpty(name));

            Console.ReadLine();
        }
    }
}
