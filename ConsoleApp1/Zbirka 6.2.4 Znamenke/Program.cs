using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbirka_6._2._4_Znamenke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodni broj:");
            int broj = int.Parse(Console.ReadLine());

            ArrayList arr = new ArrayList();            

            while (broj > 0)
            {                
                arr.Add(broj % 10); //vraća zadnju znamenku
                broj /= 10;         //djeli broj sa 10 i svaki put vraća zadnju znamenku dok rezultat djeljenja nije manji od 0
            }

            Console.Write("Ispis znamenki naopako: ");
            for (int i = 0; i < arr.Count; i++)

            {
                Console.Write(arr[i]);
            }

            Console.ReadKey();
        }
    }
}
