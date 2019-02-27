using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._6_prijestupne_godine
{
    class Program
    {
        static void Main(string[] args)
        {
            uint godina1 = 0;
            uint godina2 = 0;

            Console.Write(" unesite 1. godinu: ");
            godina1 = uint.Parse(Console.ReadLine());

            Console.Write(" unesite 2. godinu: ");
            godina2 = uint.Parse(Console.ReadLine());
            Console.WriteLine();

            for (uint i = godina1; i < godina2; i++)

                if (i % 4 == 0 && (i % 100 != 0 || i % 400 == 0))
            {
                    //Console.WriteLine();
                    Console.Write("{0}; ", i);
            }
            Console.WriteLine("\n\nza kraj stisni nešto");

            Console.ReadLine();
        }
    }
}
