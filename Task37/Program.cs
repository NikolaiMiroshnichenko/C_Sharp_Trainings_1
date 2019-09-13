using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task37
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  static void Main(string[] args)
              {
                  int a = 1;
                  int b = 2;
                  Exchange(a, b);
                  Console.WriteLine($"{a} {b}");
              }

              */
            int a = 1;
            int b = 2;
            Exchange(ref a, ref b);
            Console.WriteLine($"{a} {b}");
            Console.ReadKey();
        }
        static void Exchange(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
