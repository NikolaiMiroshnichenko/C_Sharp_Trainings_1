using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name, last name, age, sex, address, workplace");
            string s = String.Concat((Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine()));
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
