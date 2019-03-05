using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._17_potencije_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int i = 0;

            try
            {
                {
                    Console.Write("Unesite broj koji želite potencirati: ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Potencije broja {0} do {0}^10 su: \n", a);
                }

                for (i = 0; i <= 10; i = i++)

                {
                    Console.WriteLine(" {0}^{1} = {2}", a, i, Math.Pow(a, i++));

                }

            }
            catch (FormatException fex)
            {
                Console.WriteLine("GREŠKA, Nije unešen numerički znak:"
                    + fex.Message
                    + "\n"
                    + fex.ToString());
            }

            finally

            {

                Console.WriteLine("\nstisni bilo koju tipku za kraj");
                Console.ReadLine();

            }
            
        
        }
    }
}
