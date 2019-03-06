using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_Automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil auto1 = new Automobil();

            Console.Write("Marka Automobila: ");
            auto1.markaAutomobila = Console.ReadLine();
            Console.Write("Unesite snagu u KS: ");
            auto1.snaga = double.Parse(Console.ReadLine());
            Console.Write("Unesite Osnovnu Cijenu:  ");
            auto1.osnovnaCijena = double.Parse(Console.ReadLine());

            Console.Write("\nIznos Poreza za Vaš " + auto1.markaAutomobila + " je: " + auto1.Porez());
            Console.Write("\nUkupna Cijena za Vaš " + auto1.markaAutomobila + " je: " + auto1.Uk_cijena());

            Console.ReadKey();
        }

       
    }
}
