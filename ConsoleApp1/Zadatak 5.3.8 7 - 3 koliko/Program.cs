using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5._3._8_7___3_koliko
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            Console.Write(" Unesite 1. broj: ");
            a = int.Parse(Console.ReadLine());
            Console.Write(" Unesite 2. broj: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("U intervalu od {0} do {1} brojeva djeljivih sa 7 ali ne i s 3 ima: ", a, b);

            for (int i = a; i < b; i++)

                if (i % 7 == 0 && !(i % 3 == 0))

                    c ++; 

                {
                    Console.Write("{0}; ", c);
                }



            Console.WriteLine("\n\nza kraj stisni nešto");

            Console.ReadLine();
        }
    
    }
}
