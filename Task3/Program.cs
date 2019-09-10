using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            switch (name)
            {
                case "Nikolai":
                    Console.WriteLine("Dont give up, panda Nikolai!");
                    break;
                default:
                    Console.WriteLine("Since you aren’t Nikolai, continue being ordinary panda");
                    break;
            }
            Console.ReadKey();

            
        }
    }
}
