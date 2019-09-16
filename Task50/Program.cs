using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task50
{
    class Program
    {
        static void sum(decimal a, decimal b, out decimal c)
        {
            c = a + b;
        }
        static void sum(int a, int b, out int c)
        {
            c = a + b;
        }

        static void sum(double a, double b, out double c)
        {
            c = a + b;
        }
        static void Main(string[] args)
        {
            /* decimal c = 0;
             Console.WriteLine("Enter 2 numbers for sum");

             decimal.TryParse(Console.ReadLine(), out decimal a);
             decimal.TryParse(Console.ReadLine(), out decimal b);
             sum(a, b, out c);*/

            int c = 0;
            Console.WriteLine("Enter 2 numbers for sum");

            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            sum(a, b, out c);

            Console.WriteLine("sum is: " + c);
            Console.ReadKey();

            /* in first, commented realization of method "Main" 
              it calculated numbers with floating point,
              in second it dint.*/

        }
    }
}
