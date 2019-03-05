using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_7._2._5_Udaljenost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi koordinate točke P1:");
            double x1 = int.Parse(Console.ReadLine());
            double x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nUnesi koordinate točke P2:");
            double y1 = int.Parse(Console.ReadLine());
            double y2 = int.Parse(Console.ReadLine());

            Console.Write("\nUdaljenost između točaka P1 i P2 je {0}", (Udaljenost(x1, x2, y1, y2)));

            Console.ReadKey();
        }

        static double Udaljenost(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
       
    
    }
}
