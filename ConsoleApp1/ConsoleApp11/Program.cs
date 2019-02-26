using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._2._5_u_intervalu
{
    class Program
    {
        static void Main(string[] args)
        {
            float broj = 0;
            Console.Write("Unesite jedan broj: ");
            broj = int.Parse(Console.ReadLine());

            if (broj > 100 && broj < 200)
            {
                Console.WriteLine(" Unešeni broj je u intervalu 100 do 200");
            }

           
            else
            {
                Console.WriteLine(" Unešeni broj nije u intervalu 100 do 200");
            }

            Console.WriteLine("\n\tZa kraj pritisnite ENTER!");
            Console.ReadLine();
        }
    }
}
