using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_7._2._10_Ukupna_Cijena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi ulaznu cijenu: ");
            double uLC = double.Parse(Console.ReadLine());

            double pDV = (uLC + (Marza(uLC)) + (Porez(uLC)) * 25) / 100;
            double uKC = uLC + (Marza(uLC)) + (Porez(uLC)) + pDV;
           
            Console.WriteLine("\nUlazna cijena je: \t{0} kn", Math.Round((uLC), 2));
            Console.WriteLine("Marža je: \t\t{0} kn", Math.Round(Marza(uLC) ,2));
            Console.WriteLine("Porez je: \t\t{0} kn", Math.Round(Porez(uLC) ,2));
            Console.WriteLine("PDV je: \t\t{0}kn kn", Math.Round((pDV),2));
            Console.WriteLine("\nUkupna cijena je: \t{0} kn", Math.Round((uKC) ,2));

            Console.ReadKey();
        }

        static double Marza(double uLC)
        {
            double marza = 0;

            if (uLC<100)
            {
                marza = 5.5;
            }
            else if (uLC >= 100 || uLC < 250 )
            {
                marza = 9.5;
            }
            else if (uLC >= 250 || uLC < 500)
            {
                marza = 15;
            }
            else if (uLC >= 500 || uLC <= 1000)
            {
                marza = 25;
            }
            else
            {
                marza = 50;
            }

            return marza;

        }

        static double Porez(double uLC)
        {
            double porez = 0;

            if (uLC < 100)
            {
                porez = uLC * 2 / 100;
            }
            else if (uLC >= 100 || uLC < 250)
            {
                porez = uLC * 3 / 100;
            }
            else if (uLC >= 250 || uLC < 500)
            {
                porez = uLC * 4 / 100;
            }
            else if (uLC >= 500 || uLC <= 1000)
            {
                porez = uLC * 5 / 100;
            }
            else
            {
                porez = uLC * 10 / 100;
            }

            return porez;        
       
        }
    }
}
