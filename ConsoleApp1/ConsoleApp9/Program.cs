using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._2._1_pozitivan_ili_negativan_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite jedan cijeli broj: ");
            int x = int.Parse(Console.ReadLine());

            if (x == 0)

            {
                Console.WriteLine("unešeni broj je jednak 0!");
            }

            else if (x > 0)

            {
                Console.WriteLine("unešeni broj je pozitivan");
            }

            else

            {
                Console.WriteLine("unešeni broj je negativan");
            }

            Console.WriteLine("");
            Console.WriteLine("pritisnite bilo koju tipku za kraj!");

            Console.ReadKey();
        }

    }
}
