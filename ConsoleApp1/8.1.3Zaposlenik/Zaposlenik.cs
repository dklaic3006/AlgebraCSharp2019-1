using System;

namespace _8._1._3_Zaposlenik
{
    internal class Zaposlenik
    {
        private string ime;
        private string prezime;
        private double oib;
        private double brojBodova;
        private double vrijednostBoda;
        private double porez;
        private string v1;
        private string v2;
        private long v3;

        public Zaposlenik()
        {
        }

        public Zaposlenik(string ime, string prezime, long oib)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Oib = oib;
        }

        //   double netoIzračun;
        //   double brutoIzračun;


        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public double Oib { get => oib; set => oib = value; }
        public double BrojBodova { get => brojBodova; set => brojBodova = value; }
        public double VrijednostBoda { get => vrijednostBoda; set => vrijednostBoda = value; }


        public double Porez
        {
            get
            {
                double neto = this.NetoIzračun();

                if (neto < 3000)
                {
                    porez = neto * 0.06;
                }
                else if (neto < 6000)
                {
                    porez = neto * 0.12;
                }
                else
                {
                    porez = neto * 0.2;
                }

                return porez;
            }
        }

        public double NetoIzračun()
        {
            return brojBodova * vrijednostBoda;
        }

        public double BrutoIzračun()
        {
            return this.NetoIzračun() + this.Porez;   
        }
    }
}

