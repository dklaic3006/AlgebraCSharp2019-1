using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3._1_Vozila
{
    public class Automobil : Vozilo
       {
        private double ccm;

        public double Ccm { get => ccm; set => ccm = value; }
       }
    /*
    public override string ToString()
         {
          return string.Format("Naziv vozila: " + Naziv + "\nBoja: " + Boja + "\nSnaga u KS:" + Ks
           + "\nSnaga u KW:" + KStoKw());
         }
    */
}
