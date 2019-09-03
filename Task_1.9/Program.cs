using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("“How much money do you have?”");

            try
            {
                double money = double.Parse(Console.ReadLine());
                Console.WriteLine("You have " + money + " $");
            }
            catch (FormatException e)
            {
                Console.WriteLine("“Please, enter a valid number”");
            }


            Console.ReadKey();
        }
    }
}
