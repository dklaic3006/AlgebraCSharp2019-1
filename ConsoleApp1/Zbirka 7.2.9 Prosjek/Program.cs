using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbirka_7._2._9_Prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi prosječnu ocijenu: ");
            double ocjena = double.Parse(Console.ReadLine());

            Console.WriteLine("Prosijek je {0}!",(Prosijek (ocjena)));

            Console.ReadKey();
        }

        static string Prosijek(double ocjena )
        {
            string prosijek = "";

            if (ocjena < 2)
            {
                prosijek = "nedovoljan";
            }
            else if (ocjena >= 2 || ocjena <= 2.4)
            {
                prosijek = "dovoljan";
            }
            else if (ocjena >= 2.5 || ocjena <= 3.4)
            {
                prosijek = "dobar";
            }
            else if (ocjena >= 3.5 || ocjena <= 4.4)
            {
                prosijek = "vrlodobar";
            }
            else
            {
                prosijek = "ODLIČAN!!";
            }

            return prosijek;
        }
    }
}
