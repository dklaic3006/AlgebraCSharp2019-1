using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3._1_Vozila
{
    public class Vozilo
    {
        private string naziv;
        private string boja;
        private int ks;

        public string Naziv { get => naziv; set => naziv = value; }
        public string Boja { get => boja; set => boja = value; }
        public int Ks { get => ks; set => ks = value; }



        public double KstoKw()
            {
            return Ks * 0.736;
            }


    }
}
