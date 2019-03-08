using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3_Zaposlenik
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Zaposlenik zaposlenik1 = new Zaposlenik("Mario", "Antić", 70578846852);

            //Console.Write("Unesi ime: ");
            //zaposlenik1.Ime = Console.ReadLine();
            //Console.Write("Unesi prezime:");
            //zaposlenik1.Prezime = Console.ReadLine();
            //Console.Write("Unesi OIB:");
            //zaposlenik1.Oib = int.Parse(Console.ReadLine());
            Console.Write("Unesi Broj Bodova:");
            zaposlenik1.BrojBodova = double.Parse(Console.ReadLine());
            Console.Write("Unesi Vrijednosz Boda:");
            zaposlenik1.VrijednostBoda = double.Parse(Console.ReadLine());

            Console.Write("\nZaposlenik: {0} {1} {2}", zaposlenik1.Ime, zaposlenik1.Prezime, zaposlenik1.Oib);
            Console.WriteLine("\n\nNeto plaća je:\t" + zaposlenik1.NetoIzračun());
            Console.Write("\nPorez je:\t" + zaposlenik1.Porez);
            Console.WriteLine("\n\nBruto plaća je:\t" + zaposlenik1.BrutoIzračun());

            Console.ReadKey();
        }
             
    }
}
