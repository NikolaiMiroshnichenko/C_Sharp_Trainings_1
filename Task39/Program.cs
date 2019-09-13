using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eter numbers for multiplication");

            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            multiplication(a, b, out int mult);

            Console.WriteLine("result of multiolication is: " + mult);

            Console.ReadKey();
        }
        static void multiplication(int a, int b, out int mult)
        {
            mult = a * b;
        }
    }
}
