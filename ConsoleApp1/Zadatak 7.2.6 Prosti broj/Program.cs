using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_7._2._6_Prosti_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("unesi jedan prirodni broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (Prost(broj))
            {
                Console.WriteLine("uneseni broj {0} je prosti broj", broj, (Prost(broj)));
            }
            else
            {
                Console.WriteLine("uneseni broj {0} nije prosti broj", broj, (Prost(broj)));
            }

            Console.ReadKey();
        }



        static bool Prost(int broj)
        {
            bool Prost = true;
            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    Prost = false;
                    break;
                }                              
            }

            return Prost;
        }
    }
}
