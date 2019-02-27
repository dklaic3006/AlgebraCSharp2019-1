using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._7_7__3_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            Console.Write(" Unesite 1. broj: ");
            a = int.Parse(Console.ReadLine());
            Console.Write(" Unesite 2. broj: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("U intervalu od {0} do {1} brojevi djeljivi s 7 ali ne i s 3 su: ", a, b);

            for (int i = a; i < b; i++)

                if (i % 7 == 0 && !(i % 3 == 0))

                    {
                    Console.Write("{0}; ", i);
                    }
                    
            
                                   
            Console.WriteLine("\n\nza kraj stisni nešto");

            Console.ReadLine();
        }
    }
}
