using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._2._8_prijestupna_godina
{
    class Program
    {
        static void Main(string[] args)
        {
            uint godina = godina = 0;
            Console.Write("unesite godinu: ");
            godina = uint.Parse(Console.ReadLine());

            if (godina % 4 == 0 && (godina % 100 != 0 || godina % 400 == 0))

            {
                Console.WriteLine("Godina koju ste unijeli je prijestupna");
            }

            else
            {
                Console.WriteLine("Godina koju ste unijeli nije prijestupna");
            }

            Console.WriteLine();
            Console.WriteLine("pritisnite ENTER za kraj");
            Console.ReadLine();
        }
    }
}
