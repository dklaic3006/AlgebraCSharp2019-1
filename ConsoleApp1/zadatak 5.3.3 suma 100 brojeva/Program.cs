using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._3_suma_100_brojeva
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 0; i <= 100; i++)

                suma = suma += i;
            
                Console.Write("Suma prvih 100 brojeva je {0} ", suma);
            

            Console.WriteLine("\n\nza kraj stisni nešto");

            Console.ReadLine();
        }
    }
}
