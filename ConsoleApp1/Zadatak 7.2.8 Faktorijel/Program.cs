using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_7._2._8_Faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi Prirodni broj: ");
            int broj = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nFaktorijel broja {0} je: {1}", broj, (Faktorijel(broj)));

            Console.ReadKey();
        }

        static int Faktorijel(int broj)
        {
            if( broj ==1)
            {
                return broj;
            }
            
            else
            {
                return broj * Faktorijel(broj-1);
            }
            
        }
    }
}
