using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6._1._3_Zamjena_Mjesta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite 10 brojeva:");
            
            int [] niz = new int [10];
            int min = int.MaxValue;
            int max = int.MinValue;

            int minPosition = 0;
            int maxPosition = 0;

            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write("unesi {0}. element niza: ",i);
                niz[i] = int.Parse(Console.ReadLine());
                /*
                   if (niz[i] < min)
                   {
                       niz[i] = min;
                       minPosition = i;
                   }
                   if (niz[i] > max)
                   {
                       niz[i] = max;
                       maxPosition = i;
                   }
                  */
                if (max < niz[i]) 
                {
                    max = niz[i];
                    maxPosition = i;
                }
                if (min > niz [i])
                {
                    min = niz[i];
                    minPosition = i;
                }
            }
            // Zamjena mjesta
            int temp = niz[minPosition];
            niz[minPosition] = niz[maxPosition];
            niz[maxPosition] = temp;

            Console.Write("\nIspis: ");

            for (int i = 0; i < niz.Length; i++)
            {
                if (i==minPosition || i==maxPosition)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
               
                Console.Write("{0}; ", niz[i]);
                Console.ResetColor();

            }

            Console.ReadKey();
        }
    }
}
