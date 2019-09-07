using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter some value from from diaposon 0-12");
            int.TryParse(Console.ReadLine(), out int f);
            if (f < 13)
            {
                int f3 = 1;
                int f2 = f;
                for (int i = 2; i <= f; i++)
                {
                    f3 = f3 * i;
                }
                Console.WriteLine("Factorial of " + f2 + " is: " + f3);
            }
            else
            {
                Console.WriteLine("Vrong value");

            }

            Console.ReadKey();
        }
    }
}

