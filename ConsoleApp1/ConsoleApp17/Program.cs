using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2._3._18_unos_ocjene
{
    class Program
    {
        static void Main(string[] args)

        {

           
                bool unos = false;
                int ocjena = 0;
            while (!unos)

                try
                {
                    Console.Write("Unos ocjene: ");
                    ocjena = int.Parse(Console.ReadLine());

                    if ((ocjena >= 1) && (ocjena <= 5))
                    {
                        unos = true;

                        Console.WriteLine("\nUnijeli ocjenu {0}", ocjena);
                        Console.WriteLine("Unos ocjene obavljen");
                    }
                    else
                    {
                        Console.WriteLine("Pogrešan unos, unijeli ste ocjenu: {0}", ocjena);
                        Console.Write("\nMolim ponovite ");
                    }

                }
                catch (FormatException fex)
                {
                    Console.WriteLine("GREŠKA, Nije unešen numerički u rasponu 1 -5:"
                        + fex.Message
                        + "\n"
                        + fex.ToString());
                }

                 
            
            Console.WriteLine("\nstisni bilo koju tipku za kraj");
            Console.ReadLine();
            
        }
    }
}
