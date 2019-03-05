using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_7._2._3_KS_u_KW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pretvaranje KS u KW \n\n");

            Console.Write("Unesi snagu u KS: ");
            double KS = double.Parse(Console.ReadLine());

            Console.WriteLine("\nSnaga u KW je: {0}", (Snaga(KS)));

            Console.ReadKey();
        }

        static double Snaga(double KS)
        {
            return KS * 0.736 ;
        }
    }
}
