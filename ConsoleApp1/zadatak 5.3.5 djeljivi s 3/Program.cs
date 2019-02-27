using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._5_djeljivi_s_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("brojevi djeljivi s 3");
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0) 

                Console.Write(" {0} ", i);
            }
            Console.WriteLine("\n\nza kraj stisni nešto");

            Console.ReadLine();
        }
    }
}
