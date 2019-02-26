using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjer_5._2._5_paran_ili_neparan
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Uneste cijeli broj: ");
                int broj = int.Parse(Console.ReadLine());

                if (broj % 2 == 0)

                {
                    Console.WriteLine("Unešeni broj je paran!");
                }

                else

                {
                    Console.WriteLine("Unešeni broj je neparan!");

                }

            }

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za kraj!");

            Console.ReadKey();

        }

        
    }
}
