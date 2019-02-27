using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int z = 0;

            Console.WriteLine("Unesite 10 brojeva:\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("unesite {0}. broj: ", i);
                z = int.Parse(Console.ReadLine());

                if (z < min)
                {
                    min = z;
                }

                if (z > max)

                {
                    max = z;
                }

            }               
            Console.WriteLine("\nNajmanji uneseni broj je: {0}", min);
            Console.WriteLine("Najveći uneseni broj je: {0}", max);
                
            

            Console.WriteLine("\n\nza kraj stisni nešto");
            Console.ReadLine();
        }
    }
}
