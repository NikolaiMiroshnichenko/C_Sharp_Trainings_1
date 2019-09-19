using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task53
{
       class Panda
    {
        public PandaDelicacy pandaDelicacy { get; set; }

    }

    class PandaDelicacy
    {
        public string sortOfBamboo { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Panda panda1 = new Panda();
            try
            {
                Console.WriteLine(panda1.pandaDelicacy.sortOfBamboo);
            }
            catch
            {
                Console.WriteLine("NullReferenceException was catshed");
                Console.ReadKey();
            }


        }
    }
}
