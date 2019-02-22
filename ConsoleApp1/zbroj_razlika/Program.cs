using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zbroj_razlika
{
    class Program
    {
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
            Console.ReadLine();
        }
    }
}
