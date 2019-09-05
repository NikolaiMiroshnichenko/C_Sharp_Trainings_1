using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            switch (name)
            {
                case "Nikolai":
                    Console.WriteLine("You act like a pro panda, Nikolai");
                    break;
                case "Arseni":
                    Console.WriteLine("You resemble me Deadpool");
                    break;
                default:
                    Console.WriteLine("Just an ordinary name");
                    break;

            }

            Console.ReadKey();
        }
    }
}
