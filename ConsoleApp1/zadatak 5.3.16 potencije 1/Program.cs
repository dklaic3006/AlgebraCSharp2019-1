﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 


namespace zadatak_5._3._16_potencije_1
{
    class Program
    {
        static void Main(string[] args)
                    
        {
            Console.WriteLine("potencije broja 2 su: \n");
                for (int i = 0; i <= 1000; i++)

                if ( Math.Pow(2, i) <= 1000)
                             
                {
                    Console.WriteLine("2^{0}= {1}", i, Math.Pow(2 , i));
                }
            

          
            Console.WriteLine("\n\nstisni bilo koju tipku za kraj");
            Console.ReadLine();
        }
    
    }
}
