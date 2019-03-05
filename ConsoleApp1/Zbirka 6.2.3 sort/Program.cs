using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbirka_6._2._3_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unos prirodnih brojeva:\nZa kraj unesi 0:");

            List<int> listaBrojeva = new List<int>();
            int broj = -1;            

            while (broj != 0)
            {
                broj = int.Parse(Console.ReadLine());
                listaBrojeva.Add(broj);
            }

            listaBrojeva.Sort();

                foreach (int a in listaBrojeva)
                {
                    Console.Write(a);
                }
            

            Console.ReadKey();

        }
    }
}
