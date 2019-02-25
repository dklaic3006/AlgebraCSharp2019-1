using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //comment
            //comment 2
<<<<<<< HEAD
            //jhjxchjx
            /*
             * Ovo je blok komentar
             * */
            //Probna p = new Probna();
            //Console.WriteLine(p.A);
            //Console.WriteLine("Rješenje je zbroj 20 + 10 = "+ p.Add(p.A,p.b));
            Console.WriteLine("Ovo je moj " +
                " današnji " + 1 +
                "." +
                " " +
                "" +
                "program");
            //Console.ReadKey();
            Console.ReadLine();
=======
            /*
             * Ovo je blok komentar
             * */
                
            Probna p = new Probna();
            Console.WriteLine(p.A);
            Console.WriteLine("Rješenje je zbroj 20 + 10 = "+ p.Add(p.A,p.b));
            Console.ReadKey();
>>>>>>> 1da993fe071f4c181c38fb24ab36f7100880cd69
        }
    }
}
