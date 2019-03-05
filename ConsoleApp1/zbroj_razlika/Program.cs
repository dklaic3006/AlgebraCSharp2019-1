using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zbroj_razlika
{
    class Program
    {
<<<<<<< HEAD
        
        static void Main(string[] args)
        {
            int a=0, b = 0;


            Console.WriteLine(@"Unesi 1. broj\n\n\n\tjhjk\\as\'hd\jkh\tkkskd\tkk");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi 2. broj");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj je:{0}", a + b);

            Console.WriteLine("Razlika je:{0}", a - b);

            Console.WriteLine("Razlika je:{1} Zbroj je:{0}", a + b, a - b);

            Console.WriteLine("Umnožak je:{0}", a * b);

            Console.WriteLine("Kvocijent je:{0}", (decimal)a/(decimal)b);

            

=======
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.Write("Unesi 1. broj: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Unesi 2. broj: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Zbroj je: {0}", a + b);
            Console.WriteLine("Razlika je: {0}", a - b);
            Console.WriteLine();

            Console.WriteLine("Umnožak je: {0}", a * b);
            Console.WriteLine("Kvocjent je: {0}", (decimal)a / (decimal)b);
            Console.WriteLine();

            Console.WriteLine("Pritisni Enter za kraj...");
>>>>>>> 1da993fe071f4c181c38fb24ab36f7100880cd69
            Console.ReadLine();
        }
    }
}
