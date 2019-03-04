using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._15.ispis_unatrag
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.Write("{0}; ",i);
            }

            Console.WriteLine("\nstisni bilo koju tipku za kraj");
            Console.ReadLine();
        }
    }
}
