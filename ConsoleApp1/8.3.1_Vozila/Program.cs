using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3._1_Vozila
{
    class Program
    {
        static void Main(string[] args)
        {
            char upit = 'd';

            ArrayList vozila = new ArrayList();
            List<Automobil>  listaAutomobila = new List<Automobil>();
            List<Brod> listaBrodova = new List<Brod>();

            Console.WriteLine("Unesite vozilo");

            while (upit == 'd')
            {

                Console.WriteLine("Za unos Automobila birajte 'A': ");
                Console.WriteLine("Za unos Brod birajte 'B': ");
                char unos = Console.ReadKey().KeyChar;
                switch (unos)
                {

                    case 'a':

                        Automobil automobil = new Automobil();

                        Console.WriteLine("Unos Automobila:");
                        Console.Write("Unesite Naziv:");
                        automobil.Naziv = Console.ReadLine();
                        Console.Write("Unesite Boju:");
                        automobil.Boja = Console.ReadLine();
                        Console.Write("Unesite Snagu:");
                        automobil.Ks = int.Parse(Console.ReadLine());
                        Console.Write("Unesite CCM:");
                        automobil.Ccm = double.Parse(Console.ReadLine());

                        vozila.Add(automobil);
                        listaAutomobila.Add(automobil);


                        break;


                    case 'b':

                        Brod brod = new Brod();

                        brod.PromjenaIstisnine += new
                        Brod.PromjenaIstisnineDelegat(PromjenaIstisnine);

                        Console.WriteLine("Unos Broda:");
                        Console.Write("Unesite Naziv:");
                        brod.Naziv = Console.ReadLine();
                        Console.Write("Unesite Boju:");
                        brod.Boja = Console.ReadLine();
                        Console.Write("Unesite Snagu:");
                        brod.Ks = int.Parse(Console.ReadLine());
                        Console.Write("Unesite Istisninu:");
                        brod.Istisnina = double.Parse(Console.ReadLine());

                        vozila.Add(brod);
                        listaBrodova.Add(brod);
                        
                        break;
                }

                Console.Write("Želite li unijeti još vozila 'd' / 'n': ");
                upit = Console.ReadKey().KeyChar;

                if (upit == 'n')
                {
                    break;
                }
            }
                Console.WriteLine("\nU listu VOZILA unijeli ste slijedeća vozila: {0}");
                foreach (object objekt in vozila)
                {
                    Vozilo vozilo = (Vozilo) objekt;
                    Console.WriteLine("Naziv: {0}\tBoja: {1}\tSnaga u KS: {2}\tSnaga u KW: {3}", vozilo.Naziv, vozilo.Boja,
                        vozilo.Ks, vozilo.KstoKw());
                }


            Console.WriteLine("\nU listu VOZILA unijeli ste slijedeće Automobile: {0}");
            foreach (Automobil automobil in listaAutomobila)
            {                
                Console.WriteLine("Naziv: {0}\tBoja: {1}\tSnaga u KS: {2}\tSnaga u KW: {3}", automobil.Naziv,
                    automobil.Boja, automobil.Ks, automobil.KstoKw());
            }

            Console.WriteLine("u listu VOZILA unijeli ste slijedeće Brodove: {0}");
            foreach (Brod brod in listaBrodova)
            {
                Console.WriteLine("Naziv: {0}\tBoja: {1}\tSnaga u KS: {2}\tSnaga u KW: {3}", brod.Naziv,
                    brod.Boja, brod.Ks, brod.KstoKw());
            }    
            
            
            Console.ReadKey();
        
        }

        static void PromjenaIstisnine(object o, EventArgs e)

        {
            Brod brod = (Brod)o;
            Console.WriteLine("Promijenjena je istisnina!");
            Console.WriteLine("Nova istisnina je: {0}", brod.Istisnina);
        }
    }
}
