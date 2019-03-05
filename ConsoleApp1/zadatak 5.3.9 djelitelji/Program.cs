using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._9_djelitelji
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            {
                Console.Write("Unesite jedan broj: ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Djelitelji broja {0} su: ", a);

                for (int i = 1; i < a; i++)

                    if (a % i == 0)
                    {
                        Console.Write("{0}; ", i);
                    }
            
                          


            }

            Console.WriteLine("\n\nza kraj stisni nešto");

            Console.ReadLine();

            
        }

    }
    
}
