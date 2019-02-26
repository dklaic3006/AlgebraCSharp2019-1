using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._2._4_X_Znamenkasti_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            float broj = 0;
            Console.Write("Unesite jedan broj: ");
            broj = int.Parse(Console.ReadLine());

            if (broj < 10)
            {
                Console.WriteLine(" unešeni broj je jednoznamenkast");
            }

            else if (broj > 10 && broj < 100)
            {
                Console.WriteLine(" unešeni broj je dvoznamenkast");
            }

            else if (broj > 100 && broj < 1000)
            {
                Console.WriteLine(" unešeni broj je troznamenkast");
            }
            else
            {
                Console.WriteLine(" unešeni broj je višeznamenkast");
            }

            Console.WriteLine("\n\tZa kraj pritisnite ENTER!");
            Console.ReadKey();
        }
    }
}
