using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task48
{
    class Program
    {
        static void name( string name = "none")
        {
           Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            name(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
