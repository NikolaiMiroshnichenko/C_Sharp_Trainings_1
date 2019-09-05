using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your password");
            String password1 = Console.ReadLine();
            Console.WriteLine("Confirm your password");
            String password2 = Console.ReadLine();

            if(password1.Equals(password2))
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Passwords doesn’t match" );
            }

            Console.ReadKey();
        }
    }
}
