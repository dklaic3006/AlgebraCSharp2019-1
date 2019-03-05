using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._2._9_cjelobrojno_djeljenje
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = a = 0;
            Console.Write("Unesite jedan cijeli broj: ");
            a = int.Parse(Console.ReadLine());

            if (a % 3 == 0)
            {
                Console.WriteLine("broj je neparan");
            }

            if(a % 3 == 0)
            {
                Console.WriteLine("broj je djeljiv je s 3");
            }

            /*if (a % 2 == 0)
            {
                Console.WriteLine("broj je paran");
            }
            */
            else
            {
                Console.WriteLine("broj je paran " +
                    "\nbroj {0} nije djejiv s 3 " +
                    "\nostatak pri djeljenju broja {0} s 3 je: {1}", a, (a % 3));
            }
            Console.WriteLine();
            Console.WriteLine("pritisnite ENTER za kraj!");
            Console.ReadLine();
        }
    }
}
