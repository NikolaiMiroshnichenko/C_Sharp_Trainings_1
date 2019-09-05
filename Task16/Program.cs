using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter yuor name");
            string s = Console.ReadLine();
            if (s.Contains("a"))
            {
                s = s.Replace("a", "*");
            }
            
            if (s.Contains("o"))
            {
                s = s.Replace("o", "*");
            }
            if (s.Contains("i"))
            {
              s = s.Replace("i", "*");
            }

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
