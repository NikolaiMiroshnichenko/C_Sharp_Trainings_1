using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eter first, then second numbers for divide");

            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);

            divide(a, b, out int div);

            Console.WriteLine("result of divide is: " + div);

            Console.ReadKey();
        }
        static void divide (int a, int b, out int div)
        {
            div = a / b;
        }
    }
}
