using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._2._3_velik_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            float i = 0;
            Console.Write("Unesite jedan broj: ");
            i = float.Parse(Console.ReadLine());

            if (i > 999)
            {
                Console.WriteLine("Unešeni broj je velik!");
            }

            else 

            {
                Console.WriteLine("Unešeni broj nije velik!");

            }

            Console.WriteLine("\n\tZa kraj pritisnite ENTER!");
            Console.ReadKey();
        }
    }
}
