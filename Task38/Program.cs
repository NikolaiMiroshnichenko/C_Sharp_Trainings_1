using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers for sum");
           int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            summ(a, b, out int sum);
            Console.WriteLine("sum is: " + sum);

            Console.ReadKey();
        }
        static void summ (int a, int b, out int sum)
        {
            sum = a + b;
        }
    }
}
