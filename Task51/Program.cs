using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51
{
    class Program
    {
        static void PrintValue(string s)
        {
            if (s == null)
            {
                throw new NullReferenceException();

            }
            else
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string");

            PrintValue(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
