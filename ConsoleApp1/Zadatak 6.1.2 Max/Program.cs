using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6._1._2_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 5 brojeva!\n");

            int[] niz = new int [5];
            int max = int.MinValue;

            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write("unesi {0}. elemet niza: ", i+1);
                niz [i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < niz.Length; i++)
            {
                if ( niz[i] > max)
                {
                    max = niz[i];
                }
            }

            Console.WriteLine("\nIspis elementa niza:");
            for (int i = 0; i < niz.Length; i++)
            {
                if (max == niz[i])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                }

                Console.Write("{0}; " ,  niz[i]);
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
