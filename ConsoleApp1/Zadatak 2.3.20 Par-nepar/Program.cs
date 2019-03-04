using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2._3._20_Par_nepar
{
    class Program
    {
        static void Main(string[] args)
        {
           // int a = (-1);
            int broj = -1;
            int parni = 0;
            int neparni = 0;

            Console.WriteLine("\t######PAR - NEPAR#####\n");
            Console.WriteLine("Za završetak unesite 0\n\n");
            try
            {
                while (broj != 0)
                {

                    Console.Write("Unesi prirodni broj: ");
                    broj = int.Parse(Console.ReadLine());

                    if (broj != 0)

                    {
                        if (broj % 2 == 0)
                        {
                            parni++;
                        }

                        else
                        {
                            neparni++;
                        }
                    }
                }
                Console.WriteLine(" \nunijeli ste {0} parna broja", parni);
                Console.WriteLine(" unijeli ste {0} neparnih brojeva", neparni);
            }

            catch (FormatException fex)

            {
                Console.WriteLine("\n\nGREAŠKA - niste unijeli numeričku vrijednost\n" + fex.Message);
            }
                Console.WriteLine("\nstisni bilo koju tipku za kraj");
                Console.ReadLine();
        }    
    }
}
