using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ucenik
{
    class Program
    {
        private static object racun;

        //public static int racun { get; private set; }

        static void Main(string[] args)
        {
            Ucenik ucenik1 = new Ucenik("Mario", "Marović", "70578846852", "3568");
            Ucenik ucenik2 = new Ucenik("Darija", "Selak", "12345846852");
            Ucenik ucenik3 = new Ucenik("Silvio", "Habat");

            List<Ucenik> listaUcenika = new List<Ucenik>();
            listaUcenika.Add(ucenik1);
            listaUcenika.Add(ucenik2);
            listaUcenika.Add(ucenik3);

            if (ucenik1.Oib == null)
            {
                Console.Write("Unesi oib za " + ucenik1.Ime + " " + ucenik1.Prezime + " : ");
                ucenik1.Oib = Console.ReadLine();
                listaUcenika.Add(ucenik1);
            }
            if (ucenik2.Oib == null)
            {
                Console.Write("Unesi oib za " + ucenik2.Ime + " " + ucenik2.Prezime + " : ");
                ucenik2.Oib = Console.ReadLine();
                listaUcenika.Add(ucenik2);
            }
            if (ucenik3.Oib == null)
            { 
                Console.Write("Unesi oib za " + ucenik3.Ime + " " + ucenik3.Prezime + " : ");
                ucenik3.Oib = Console.ReadLine();
                listaUcenika.Add(ucenik3);
            }

            if (ucenik1.Racun != null)
            {
                ucenik1.Racun = ucenik1.Racun;
            }
            else
            {                
                       Random rng = new Random();
                       int randomNumber = rng.Next(2000, 6000);
                       ucenik1.Racun = randomNumber.ToString(); 
            }

            if (ucenik2.Racun != null)
            {
                ucenik2.Racun = ucenik2.Racun;
            }
            else
            {
                Random rng = new Random();
                int randomNumber = rng.Next(2000, 6000);
                ucenik2.Racun = randomNumber.ToString();
                System.Threading.Thread.Sleep(20);
            }

            if (ucenik3.Racun != null)
            {
                ucenik3.Racun = ucenik3.Racun;
            }
            else
            {
                Random rng = new Random();
                int randomNumber = rng.Next(2000, 6000);
                ucenik3.Racun = randomNumber.ToString();
            }

                                 
            Console.Write("Unesi broj telefona za " + ucenik1.Ime + " " + ucenik1.Prezime + " : ");
            ucenik1.Telefon = int.Parse(Console.ReadLine());
            listaUcenika.Add(ucenik1);
            Console.Write("Unesi broj telefona za " + ucenik2.Ime + " " + ucenik2.Prezime + " : ");
            ucenik2.Telefon = int.Parse(Console.ReadLine());
            listaUcenika.Add(ucenik2);
            Console.Write("Unesi broj telefona za " + ucenik3.Ime + " " + ucenik3.Prezime + " : ");
            ucenik3.Telefon = int.Parse(Console.ReadLine());
            listaUcenika.Add(ucenik3);

            Console.Write("Unesi početno stanje računa za " + ucenik1.Ime + " " + ucenik1.Prezime + " : ");
            ucenik1.PoStRacuna = double.Parse(Console.ReadLine());
            listaUcenika.Add(ucenik1);
            Console.Write("Unesi početno stanje računa za " + ucenik2.Ime + " " + ucenik2.Prezime + " : ");
            ucenik2.PoStRacuna = double.Parse(Console.ReadLine());
            listaUcenika.Add(ucenik2);
            Console.Write("Unesi početno stanje računa za " + ucenik3.Ime + " " + ucenik3.Prezime + " : ");
            ucenik3.PoStRacuna = double.Parse(Console.ReadLine());
            listaUcenika.Add(ucenik3);


            Console.WriteLine("\nUčenik: \n{0} {1}", ucenik1.Ime, ucenik1.Prezime);
            Console.WriteLine("OIB: \t{0}", ucenik1.Oib);
            Console.WriteLine("Br. Racuna: {0}\tStanje: {1}", ucenik1.Racun, ucenik1.StanjeRacuna());
            Console.WriteLine("\nUčenik: \n{0} {1}", ucenik2.Ime, ucenik2.Prezime);
            Console.WriteLine("OIB: \t{0}", ucenik2.Oib);
            Console.WriteLine("Br. Racuna: {0}\tStanje: {1}", ucenik2.Racun, ucenik2.StanjeRacuna());
            Console.WriteLine("\nUčenik: \n{0} {1}", ucenik3.Ime, ucenik3.Prezime);
            Console.WriteLine("OIB: \t{0}", ucenik3.Oib);
            Console.WriteLine("Br. Racuna: {0}\tStanje: {1}", ucenik3.Racun, ucenik3.StanjeRacuna());


            Console.ReadKey();
        }

        
    }
}
