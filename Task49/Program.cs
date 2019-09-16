using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task49
{
    class Program
    {

        static void nameAndLastname(string name, string lastName = "")
        {
            Console.WriteLine(name + " " + lastName);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter youyr name & last name");
            nameAndLastname(Console.ReadLine(), Console.ReadLine());

            Console.ReadKey();
        }
    }
}
