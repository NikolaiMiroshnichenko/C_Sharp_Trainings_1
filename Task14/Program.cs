using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your first name");
            String name = Console.ReadLine();
            Console.WriteLine("Input your last name");
            String lastName = Console.ReadLine();
            Console.WriteLine("Input your age");
            int age = int.Parse(Console.ReadLine());

            String result = $"Your personal data is: {name} {lastName} {age}";
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
