using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_7._2._1_Krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi radijus kruga: ");
            double r = double.Parse(Console.ReadLine());


            //Opseg(Opseg);
            //Povrsina(Povrsina);

            Console.WriteLine("Opseg Kruga je: {0} ", (Opseg (r)));

            Console.WriteLine("Površina Kruga je: {0} ", Math.Round(Povrsina(r),4));

            Console.ReadKey();
        }

        static double Opseg(double r)
        {
           return 2 * r * 3.14;
            
        }

        static double Povrsina(double r)
        {
            return  Math.Pow(r, 2) * 3.14;
            
        }
    }


}
