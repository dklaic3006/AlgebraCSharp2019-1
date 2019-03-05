using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._4_faktorijel
{
    class Program
    {
        static void Main(string[] args)
        { 
            int x = 0;
            int faktorijel = 1;

            {
                Console.Write("Unesite cijeli broj: ");

                try
                {


                    x = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= x; i++)
                    {
                        faktorijel *= i;
                    }
                    Console.WriteLine("\n\n{0}! = {1}", x, faktorijel);
                }

                catch (Exception ex)

                {
                    Console.WriteLine(ex.ToString());
                }
            }
            
            Console.WriteLine("\n\nza kraj stisni nešto");

            Console.ReadLine();
        }
    }
    
}
