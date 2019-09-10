using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter password");
            String password = Console.ReadLine();
            String hiddenPassword = password.Replace(password, "******");
            Console.WriteLine("Name: {"+ name +"} Password: {" + hiddenPassword +"}");

            Console.ReadKey();
        }

        
    }
}
