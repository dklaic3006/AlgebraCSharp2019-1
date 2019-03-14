using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1._3_automobili
{
    class Program
    {
        static void Main(string[] args)
        {

            char upit = 'd';

            List<Autombil> listaAutomobila = new List<Autombil>();

            Console.WriteLine("Upis Automobila:");

            while (upit == 'd')

            {
                listaAutomobila.Add(UnosAutomobila());

                Console.Write("Za unijeti novi automobil - 'd'");
                upit = Console.ReadKey().KeyChar;
            }


            List<Autombil> trAuto = (from au in listaAutomobila orderby au.Model where au.Zapremina > 1600 select au).ToList();


            Console.WriteLine("\nAutomobili velike zapremine\n");
            foreach (Autombil autombil in trAuto)
            {
                Console.WriteLine("Marka: " + autombil.Marka + "\tModel: " + autombil.Model
                                + "\tZapremina: " + autombil.Zapremina);
            }


            Console.ReadKey();
        }

        private static Autombil UnosAutomobila()
        {         

                Autombil automobil = new Autombil();
                Console.Write("\nMarka: ");
                automobil.Marka = Console.ReadLine();
                Console.Write("Model: ");
                automobil.Model = Console.ReadLine();
                Console.Write("Zapremina: ");
                automobil.Zapremina = int.Parse(Console.ReadLine());

                return automobil;
            
        }
    }
}



