using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task67
{
    class Program
    {
        class Person
        {
            public string name { get; set; }
            public string lastName { get; set; }
            public int age { get; set; }
            public override string ToString()
            {
                return ($"{name}, {lastName }, {age}");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter you last name");
            string name2 = Console.ReadLine();
            Console.WriteLine("Enter your age");
            if (int.TryParse(Console.ReadLine(), out int age1))
            {
                Person person = new Person();
                person.name = name1;
                person.lastName = name2;
                person.age = age1;
                Console.WriteLine(person.ToString());
            }
            else
            {
                throw new FormatException();
            }

            Console.ReadKey();
        }
    }
}
