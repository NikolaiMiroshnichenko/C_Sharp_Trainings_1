using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task66
{
    class programm
    {
        class Person
        {
            string name { get; set; }
            string lastName { get; set; }
            int age { get; set; }
            public Person(string name, string lastName, int age)
            {
                name = "Nikolai";
                lastName = "Miroshnichenko";
                age = 27;
            }
        }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
