using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._20_kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0;
            string c = "";
            string z = "";

            while (z == "d" || z == "D")

            // if (z != "da" || z != "Da" || z != "DA")
            {
                try
                {
                    Console.Write("Unesite 1. broj: ");
                    a = float.Parse(Console.ReadLine());

                    Console.Write("Unesite 2. broj: ");
                    b = float.Parse(Console.ReadLine());

                    Console.Write("Unesite željenu računsku operaciju (+, -, *, /): ");
                    c = Console.ReadLine();

                    if (c != "+" || c != "-" || c != "*" || c != "/")
                    {
                        throw new Exception_neispravna_racunska_operacija("neispravna racunska operacija");
                    }

                    if (b == 0)
                    {
                        throw new Exception_nemoguce_djeljenje_1("nemoguće je djeliti s 0");
                    }

                    if (b > a)
                    {
                        throw new Exception_nemoguce_djeljenje_2("djelitelj je veći od djeljenjika");
                    }
                }

                catch (Exception_neispravna_racunska_operacija)

                {
                    //Console.WriteLine("Nije unešen odgovarajući simbol računske operacije");
                }

                catch (Exception_nemoguce_djeljenje_1)
                {
                    Console.WriteLine("nije moguće djeliti s 0");
                }

                catch (Exception_nemoguce_djeljenje_2)
                {
                    Console.WriteLine("nije moguće djeljnje manjeg broja s većim");
                }

                finally

                {
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
                }

                //else if (z == "da" || z == "Da" || z == "DA")

                Console.Write("\n Želite li obaviti novu računsku operaciju D / N:  ");
                z = Console.ReadLine();
                /*

                else
                {
                    Console.WriteLine(" KRAJ");
                    Console.ReadLine();
                }
                */
            }
        }          
        }
        public class Exception_neispravna_racunska_operacija : Exception
        {
            public Exception_neispravna_racunska_operacija()
            {
            }

            public Exception_neispravna_racunska_operacija(string message) : base(message)
            {
                Console.WriteLine("Nije unešen odgovarajući simbol računske operacije");
            }

            public Exception_neispravna_racunska_operacija(string message, Exception inner) : base(message, inner)
            {

            }

        }

       public class Exception_nemoguce_djeljenje_1 : Exception
        {
            public Exception_nemoguce_djeljenje_1()
            {
            }

            public Exception_nemoguce_djeljenje_1(string message) : base(message)
            {
                Console.WriteLine("Nije moguće djeljenje s 0");
            }

            public Exception_nemoguce_djeljenje_1(string message, Exception inner) : base(message, inner)
            {

            }
        }

            public class Exception_nemoguce_djeljenje_2 : Exception
            {
                public Exception_nemoguce_djeljenje_2()
                {
                }

                public Exception_nemoguce_djeljenje_2(string message) : base(message)
                {
                    Console.WriteLine("nije moguće djeljnje manjeg broja s većim");
                }

                public Exception_nemoguce_djeljenje_2(string message, Exception inner) : base(message, inner)
                {

                }

            }
}
