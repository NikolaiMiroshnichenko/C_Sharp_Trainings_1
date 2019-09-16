using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter some numbers untill \"quit\" or \"exit\"");
            string s = "";

            string c;
           /* do
            {
                c = Console.ReadLine();
                s = s + " " + c;
                bool b1 = c != "quit";
                bool b2 = c != "exit";
                bool b3 = b1 || b2;
            } while (c!="quit"&&c!="exit");*/

            while (true)
            {
                c = Console.ReadLine();
                
                if (c=="quit"|| c == "exit")
                {
                    break;
                }
                else
                {
                    s = s + " " + c;
                }
            }


            Console.Write(s);

            Console.ReadKey();

        }
    }
}
