using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_Proizvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Proizvod pr1 = new Proizvod();

            Console.Write("Naziv: ");
            pr1.naziv = Console.ReadLine();
            Console.Write("Cijena: ");
            pr1.cijena = double.Parse(Console.ReadLine());
            Console.Write("Marža: ");
            pr1.marza = double.Parse(Console.ReadLine());
            Console.Write("Porez: ");
            pr1.porez = double.Parse(Console.ReadLine());

            Console.Write("MPC cijena za " + pr1.naziv + " je: " + pr1.Mpc() + " kn");

            Console.ReadLine();
        }

        
    }
}
