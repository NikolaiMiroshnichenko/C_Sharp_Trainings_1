using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name, last name, age, sex, address, workplace");
            String s = Console.ReadLine();
            s = s+ " " + Console.ReadLine();
            s = s + " " + Console.ReadLine();
            s = s + " " + Console.ReadLine();
            s = s + " " + Console.ReadLine();
            s = s + " " + Console.ReadLine();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
