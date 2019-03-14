using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1._1_Imena
{
    class Program
    {
        static void Main(string[] args)
        {
            string ime =("");

            List<string> listaImena = new List<string>();

            Console.WriteLine("Unos Imena.\nZa završetak unosa upišite: \"kraj\"");
            while (ime.ToLower() != "kraj") 
            {                
                ime = Console.ReadLine();
                listaImena.Add(ime);
            }

            List<string> imenaSaSlovomA = (from im in listaImena
                                           where im.ToLower().Contains("a")
                                           select im).ToList();

            foreach (var im in imenaSaSlovomA)
            {
                Console.Write(im + " ");
            }



            Console.ReadLine();
        }
    }
}
