using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._10_savrseni_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int suma = 0;
        
                Console.Write("Unesite jedan broj: ");
                a = int.Parse(Console.ReadLine());

                for (int i = 1; i < a; i++)
                {
                if (a % i == 0)
                
                    {
                        suma += i;
                    }                    
                }   
                                             
                if (suma == a)

                {
                    Console.WriteLine("zbroj djelitelja je {0}", suma);
                    Console.WriteLine("broj koji ste uniejeli je savršen!");
                }

                else

                {
                    Console.WriteLine("zbroj djelitelja je {0}", suma);
                    Console.WriteLine("broj koji ste unijeli nije savršen!");
                }

            Console.WriteLine("\n\nza kraj stisni nešto");

            Console.ReadLine();
        }
    }
}
