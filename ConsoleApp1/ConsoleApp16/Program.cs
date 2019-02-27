using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._12_suma_i_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            Console.WriteLine("unesite 5 brojeva:\n");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Unesite {0}. broj: ", i);
                suma += int.Parse(Console.ReadLine());

            }

            {
                Console.WriteLine("\nSuma unesenih brojeva je {0}: ", suma);
                Console.WriteLine("\nProsijek unesenih brojeva je {0}: ", suma / 5);
            }

            Console.WriteLine("\n\nza kraj stisni nešto");
            Console.ReadLine();

        }
    }
}
