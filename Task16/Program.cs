using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter yuor name");
            string s = Console.ReadLine();
            if (s == null)
            {
                Console.WriteLine("You didnt input your name");
            }
            else
            {
                s = s.Replace("a", "*");

                s = s.Replace("o", "*");

                s = s.Replace("i", "*");
            }
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
