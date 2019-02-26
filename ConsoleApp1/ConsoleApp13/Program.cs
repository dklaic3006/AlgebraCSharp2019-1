using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._2._7_dobar_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            float broj = 0;
            Console.Write("Unesite jedan broj: ");
            broj = int.Parse(Console.ReadLine());

            if (broj % 4 == 0 && broj > 100)
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
