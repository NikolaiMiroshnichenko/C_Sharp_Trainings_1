using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers until \"exit\" or \"quit\"");
            int i = 0;
            string s="";
            while (s != "exit" && s != "quit") {
             s= Console.ReadLine();
                i++;
            }
            i = i - 1;
            Console.WriteLine("you enter " + i + " numbers");


            Console.ReadLine();

        }
    }
}
