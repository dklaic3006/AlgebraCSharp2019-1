using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_7._2._2.jdnakokracan_trokut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Površina jednakokračnog trokuta\n\n");

            Console.Write("Unesi duljinu kateta: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Unesi duljinu baze: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("\nPovršina trokuta je: {0}", (Povrsina(a, b)));

            Console.ReadKey();
        }

        static double Povrsina (double a, double b)
        {
            return (a * b) / 2;
        }
       
    }
}
