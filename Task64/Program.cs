using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task64
{
    class Program
    {
        struct Person
        {
            public string name;
            public string lastName;
            public int age;
           
        }
        static void Main(string[] args)
        {
            Person marvellPers = new Person { name = "DeadPool", lastName = "MarvelousDeadPoll", age = 30 };

            Console.ReadKey();
        }
    }
}

