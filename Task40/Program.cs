using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eter first, then second numbers for subtraction");

            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            subtraction(a, b, out int mult);

            Console.WriteLine("result of subtruction is: " + mult);

            Console.ReadKey();
        }
        static void subtraction (int a, int b, out int subtr)
        {
            subtr = a - b;
        }
    }
}
