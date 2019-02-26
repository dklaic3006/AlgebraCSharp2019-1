using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0;
            string c = "";

            Console.Write("Unesite 1. broj: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Unesite 2. broj: ");
            b = float.Parse(Console.ReadLine());

            Console.Write("Unesite željenu računsku operaciju (+, -, *, /): ");
            c = Console.ReadLine();
            
            switch (c)
            
            {
                case "+":
                case "plus":

                    Console.WriteLine("Zbroj je: {0} + {1} = {2} ", a, b, (a + b));
                    break;

                case "-":
                    Console.WriteLine("Razlika je: {0} - {1} = {2} ", a, b, (a - b));
                    break;

                case "*":
                case "x":
                    Console.WriteLine("Umnožak je: {0} * {1} = {2} ", a, b, (a * b));
                    break;

                case "/":
                    Console.WriteLine("Kvocijent je: {0} / {1} = {2} ", a, b, (a / b));
                    break;
            }

            Console.Write("\n Za novu računsku operacuju unesite \"Y\" \n Za kraj pritisnite ENTER: " );
            string y = Console.ReadLine();

            //if (y == "Y" || y == "y")

            Console.ReadKey();
            


        }
    }
}
