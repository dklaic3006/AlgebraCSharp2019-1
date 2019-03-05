using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjer_5._2._4._2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Unesite ime: ");
            string ime = Console.ReadLine();

            if (ime == "Tomislav" || ime == "Hrvoje" || ime == "Mislav ")
            {
                Console.WriteLine("Dobar dan direktore " + ime);
            }                                         
            
            else
            
            {
                Console.WriteLine("Bog! ");
            }


            {
                Console.WriteLine();

                Console.Write("Pritisnite ENTER za kraj: ");

            }




            Console.ReadKey();

        }
       
    }
}
