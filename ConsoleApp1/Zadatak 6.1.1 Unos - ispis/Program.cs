using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6._1._1_Unos___ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 10 prirodnih brojeva!\n");

            /* int broj = 0;
                ArrayList lista = new ArrayList();

             for (int i = 0; i < 10; i++)
             {
                 broj = int.Parse(Console.ReadLine());
                 lista.Add(broj);
             }

             for (int i = 0; i < lista.Count; i++)
             {
                 Console.WriteLine("\n{0}. elemet niza je:{1} ", i, lista[i]);
             }
             */

            int[] niz = new int[10];
            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write("Unesi {0}. element niza: ", i);
                niz[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nUnesen je slijedeći niz:");

            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write("{0} ", niz[i]);
            }

            Console.ReadKey();
        }
    }
}
