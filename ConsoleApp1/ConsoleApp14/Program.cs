using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlje_primjeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ispis svih brojeva 0,1,2......99\n!");
            //ispis svih brojeva 0,1,2......99
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n\nispis svih brojeva 16,18......89!\n");
            //ispis svih brojeva 16,18......89
            for (int i = 16; i < 89; i+=2)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n\nispis svih brojeva 135,130,125.....55!\n");
            //ispis svih brojeva 135,130,125.....55
            for (int i = 135; i > 54; i -= 5)
            {
                Console.Write("{0} ", i);
            }
            
            Console.WriteLine("\n\nispis svih brojeva od 0 do 1000 djeljivih sa 17 i 13!\n");
            //ispis svih brojeva 01,1,2....99 preskoči 80
            for (int i = 0; i < 10000; i++)
            {
                if ( i % 17 == 0 && i % 13 ==0)
                {
                    Console.Write("{0} ", i);
                }
                
            }

            Console.WriteLine("\n\nispis svih brojeva 135,130,125.....55!\n");
            //ispis svih brojeva 01,1,2....99 preskoči 80
            for (int i = 135; i > 54; i -= 5)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n\ntablica množenja\n");
            
            for (int i = 1; i <= 10; i++)

            {
                for (int j = 0; j <=10; j++)
                {
                    Console.Write("{0}\t", (i * j));
                }
                
            }

            Console.WriteLine("\n\n\nPritisnite bilo koju tipku za kraj!");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
