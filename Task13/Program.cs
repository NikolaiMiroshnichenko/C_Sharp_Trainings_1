using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money do you have?");
            float money = float.Parse(Console.ReadLine());

            Console.WriteLine("You have " + money +"$");
            Console.ReadKey();
        }
    }
}
