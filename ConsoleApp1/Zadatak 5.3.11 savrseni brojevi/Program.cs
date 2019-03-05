using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5._3._11_savrseni_brojevi
{
    class Program
    {
        static void Main(string[] args)

        {
            //int prvi = 0;
            //int drugi = 0;
            int zbr_dj = 0;
            int i = 0;
            int j = 0;
            /*
            Console.Write("Unesite PRVI broj: ");
            prvi = int.Parse(Console.ReadLine());
            Console.Write("Unesite PRVI broj: ");
            drugi = int.Parse(Console.ReadLine());
            */
            for (i = 1; i <= 1000; i++)
            {
                for (j = 1; j < i; j++)

                {
                    if (i % j == 0)

                    {
                        zbr_dj += j;
                    }

                }

                if (i == zbr_dj)
                {
                    Console.WriteLine("{0} ", i.ToString());
                }


            }

            Console.WriteLine("\n\nza kraj stisni nešto");

            Console.ReadLine();

        }
    }
}
