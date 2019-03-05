using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_7._2._4.Celzij_u_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pretvaranje C u F \n\n");

            Console.Write("Unesi temperaturu u stupnjevima Celzijusa: ");
            double Tc = double.Parse(Console.ReadLine());
           
            Console.WriteLine("\ntemperatura u stupnjevima Fahrenheit-a je: {0}", (Temperatura(Tc)));

            Console.ReadKey();
        }

        static double Temperatura(double Tc)
        {
            return (Tc * 9 / 5 ) + 32;
        }
    }
}
