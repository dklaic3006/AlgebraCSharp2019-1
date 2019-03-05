using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._1_neparni_do_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nispis neparnih brojeva od 0 do 20!");

            for (int i = 1; i < 20; i+=2)
            {
                            
                Console.Write("{0} ", i);
                
            }

            Console.ReadLine();
        }
    }
}
