using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Molim upišite naziv škole koju trenutno pohađate: ");
            string skola = Console.ReadLine();

            if (skola != "Algebra")

            {
                Console.WriteLine("Upišite informatički seminar u Algebri! :-)");
            }
            {
            Console.WriteLine();
            Console.WriteLine("Pritisnite ENTER za kraj:");
            }

            Console.ReadKey();
        }
    }
}
