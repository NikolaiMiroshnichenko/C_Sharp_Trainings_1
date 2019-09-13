using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task36
{
    class Program
    {
        static void Main(string[] args)
        {
            /*static void Main(string[] args)
            {
                int a = 1;
                int b;
                Increment(a, b);
                Console.WriteLine($"{a} {b}");
            }

            static void Increment(int a, out int b)
            {
                b = ++a;
            }*/
            int a = 1;
            int b;
            Increment(a,out b);
            Console.WriteLine($"{a} {b}");
            Console.ReadKey();
        }
        static void Increment(int a, out int b)
        {
            b = ++a;
        }

    }
}
