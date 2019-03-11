using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ucenik_drugi_nacin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> listaUcenika = new List<Ucenik>
            {
                new Ucenik ("Ozren", "Orkic"),
                new Ucenik ("Marija", "Maric", 62359956123),
                new Ucenik ("Ivan", "Ivic", 70578846852, "3456"),
            };


            listaUcenika.ForEach(Ucenik => UnesiOib(Ucenik));
            listaUcenika.ForEach(Ucenik => UnesiTelefon(Ucenik));
            listaUcenika.ForEach(Ucenik => UnesiPoStRacuna(Ucenik));
            listaUcenika.ForEach(Ucenik => ProvjeriRacun(Ucenik));
            listaUcenika.ForEach(Ucenik => IspisUcenika(Ucenik));



            Console.ReadKey();
        }

        private static void IspisUcenika(Ucenik ucenik)
        {
            Console.WriteLine("\nUčenik: \n{0} {1}", ucenik.Ime, ucenik.Prezime);
            Console.WriteLine("OIB: \t*******{0}", ucenik.PartialOib);
            Console.WriteLine("Br. Racuna: {0}\tStanje: {1}", ucenik.Racun, ucenik.StanjeRacuna());
        }

        private static void ProvjeriRacun(Ucenik ucenik)
        {
            if (ucenik.Racun != null)
            {
                ucenik.Racun = ucenik.Racun;
            }
            else
            {
                Random rng = new Random();
                int randomNumber = rng.Next(2000, 6000);
                ucenik.Racun = randomNumber.ToString();
                System.Threading.Thread.Sleep(20);

            }
        }

        private static void UnesiPoStRacuna(Ucenik ucenik)
        {
            Console.Write("Unesi početno stanje računa za " + ucenik.Ime + " " + ucenik.Prezime + " : ");
            ucenik.PoStRacuna = double.Parse(Console.ReadLine());
        }

        private static void UnesiTelefon(Ucenik ucenik)
        {
            Console.Write("Unesi broj telefona za " + ucenik.Ime + " " + ucenik.Prezime + " : ");
            ucenik.Telefon = float.Parse(Console.ReadLine());
        }

        public static void UnesiOib(Ucenik ucenik)
        {

            while (ucenik.oib <= 999999999 || ucenik.oib >= 999999999999)
            {
                try
                {
                    Console.Write("Unesi OIB za ucenika {0} {1}: ", ucenik.Ime, ucenik.Prezime);
                    ucenik.Oib = long.Parse(Console.ReadLine());

                    while (ucenik.oib <= 999999999 || ucenik.oib >= 999999999999)
                    {
                        Console.Write("Uneseni OIB nije ispravan\nUnesi OIB za ucenika {0} {1}: ", ucenik.Ime, ucenik.Prezime);
                        ucenik.Oib = long.Parse(Console.ReadLine());

                    }

                }

                catch (FormatException ex)
                {
                    Console.WriteLine(" Greška - " + ex.Message);
                }

                catch (Exception fex)
                {
                    Console.WriteLine(" Greška - " + fex.Message);
                }
            }
        }

    }
}

