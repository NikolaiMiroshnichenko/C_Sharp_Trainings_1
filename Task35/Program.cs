using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task35
{
    class Program
    {
        static void Increment(ref int a, ref int b)
        {
          a++;
          b++;
            
        }
        static void Main(string[] args)
        {
            /* static void Main(string[] args)
             {
                 int a = 1;
                 int b = 2;
                 Increment(a, b);
                 Console.WriteLine($"{a} {b}");
             }

             static void Increment(int a, int b)
             {
                 a++;
                 b++;
             }*/

            int a = 1;
            int b = 2;                   
            Increment(ref a, ref b);

            Console.WriteLine($"{a} {b}");

            Console.ReadKey();

        }


    }
}
