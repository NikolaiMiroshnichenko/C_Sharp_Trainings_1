using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task54
{
    class Program
    {
        static void paramString(params string[] stringArray)
        {
            string s = "";
            for (int i = 0; i < stringArray.Length; i++)
            {
                s = s + stringArray[i];                
            }
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some strinngs");
            paramString(Console.ReadLine(), Console.ReadLine(),Console.ReadLine());

            Console.ReadKey();
        }
    }
}
