using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your age");
            if ((int.TryParse(Console.ReadLine(), out int age)) == false)
            {
                Console.WriteLine("WTF you entered?");
            }
            else

            if ((0 <= age) && (age <= 18))
            {
                Console.WriteLine("Go play LoL, kid");
            }
            else if ((18 < age) & (age <= 25))
            {
                Console.WriteLine("You can play Dota from Warcraft");
            }
            else if (25 < age)
            {
                Console.WriteLine(" You can play all of you want, death is close anyway...");
            }
            else Console.WriteLine("WTF you entered?");
            Console.ReadKey();

        }
    }
}
