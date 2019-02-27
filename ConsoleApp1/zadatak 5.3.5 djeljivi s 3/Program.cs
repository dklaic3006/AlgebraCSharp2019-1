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
            //Console.WriteLine("brojevi djeljivi s 3");

            try
            {

                Console.Write("Unesite 1. broj: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Unesite 2. broj: ");
                int b = int.Parse(Console.ReadLine());

                if (b > a)

                {
                    throw new Exception("Nepravilan interval");
                }

                Console.Write("\nbrojevi djeljivi s 3 u intervalu od {0} do {1} su: ", a, b);

                for (int i = a; i <= b; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.Write(" {0};  ", i);
                    }

                }
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.ToString());
            }


            Console.WriteLine("\n\nza kraj stisni nešto");

            Console.ReadLine();
        }
    }
}
