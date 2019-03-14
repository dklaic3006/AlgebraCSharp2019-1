using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1._4_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("traži se unos Brojeva, za kraj unesite 0");

            int broj = -1;

            List<int> listaBrojeva = new List<int>();

            while(broj != 0)
            {
                Console.Write("unesi broj: ");
                broj = int.Parse(Console.ReadLine());
                listaBrojeva.Add(broj);
            }

            int neparni = (from br in listaBrojeva where br % 2 != 0 select br).Count();

            int parni = listaBrojeva.Count - neparni;

            Console.WriteLine(" parnih je: " + parni);
            Console.WriteLine(" neparnih je: " + neparni);

            Console.ReadKey();
        }
    }
}
