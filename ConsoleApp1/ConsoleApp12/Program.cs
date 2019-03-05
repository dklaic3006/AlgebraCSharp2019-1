using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._2._6_dobar_broj_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float broj = 0;
            Console.Write("Unesite jedan broj: ");
            broj = int.Parse(Console.ReadLine());

            if (broj % 3 == 0 || broj % 5 ==0)
            {
                Console.WriteLine(" Unešeni broj je u dobar");
            }


            else
            {
                Console.WriteLine(" Unešeni broj nije dobar");
            }

            Console.WriteLine("\n\tZa kraj pritisnite ENTER!");
            Console.ReadLine();
        }
    }
}
