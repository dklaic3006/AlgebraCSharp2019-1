using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaracija niza od 3 elementa

            int[] niz = new int[3];

            //inicijalizacija niza

            niz[0] = 55;
            niz[2] = 22;
            niz[1] = 77;

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine("{0}. element niza: {1}", i, niz[i]);
            }

            Console.ReadKey();
        }
    }
}
