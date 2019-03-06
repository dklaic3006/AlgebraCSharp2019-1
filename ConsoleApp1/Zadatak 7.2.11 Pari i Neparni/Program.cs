using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_7._2._11_Pari_i_Neparni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unos prirodnih brojeva!\nza završetak unesi: 0\n");

            ArrayList brojevi = Unos();

            Console.Write("\nIspis neparnih brojeva: ");
            Ispis(Neparni(brojevi));
            Console.Write("\nIspis parnih brojeva: ");
            Ispis(Parni(brojevi));


            Console.ReadKey();
        }

        static ArrayList Unos()
        {
            int i = 0;
            ArrayList brojevi = new ArrayList();

            while (true)
            {
                i++;
                Console.Write("Unesi {0}. broj: ", i);
                int broj = int.Parse(Console.ReadLine());

                if (broj == 0)
                {
                    break;
                }

                brojevi.Add(broj);
            }

            return (brojevi);

        }

        static void Ispis(ArrayList brojevi)
        {
            foreach (int z in brojevi)
            {
                Console.Write("{0}; " ,z);
            }
        }

        static ArrayList Neparni(ArrayList brojevi)
        {
            ArrayList Neparni = new ArrayList();
            foreach (int br in brojevi)
            {
                if (br % 2 != 0)
                {
                    Neparni.Add(br);
                }
            }

            return Neparni;
        }

        static ArrayList Parni(ArrayList brojevi)
        {
            ArrayList Parni = new ArrayList();
            foreach (int nbr in brojevi)
            {
                if (nbr % 2 == 0) 
                {
                    Parni.Add(nbr);
                }

            }

            return Parni;
        }

    }
}
