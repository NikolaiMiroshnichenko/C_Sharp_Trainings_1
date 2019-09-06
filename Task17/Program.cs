using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password");
            String password1 = Console.ReadLine();
            Console.WriteLine("Confirm your password");
            String password2 = Console.ReadLine();
            int i = 0;
            if ((password1.Contains(" ") | (password1.Contains(" "))))
            {
                Console.WriteLine("Password may not contain numspace");
            }
            else
            {
                if (password1.Equals(password2) && (password1 != null) && (password1 != null))
                {

                    while (i < password1.Length)
                    {
                        password1 = password1.Replace(password1[i], '*');
                        i++;
                    }

                    Console.WriteLine("Success. Your password is " + password1);
                }
                else
                {
                    Console.WriteLine("Please, check you password. It doesn’t match");
                }
            }

            Console.ReadKey();
        }
    }
}
