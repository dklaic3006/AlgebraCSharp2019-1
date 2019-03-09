using System;

namespace _1_ucenik
{
    internal class Ucenik
    {
        private string ime;
        private string prezime;
        private string oib;
        
        private float telefon;
        double poStRacuna;
        private string racun;

        public Ucenik(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }

        public Ucenik(string ime, string prezime, string oib) : this(ime, prezime)
        {
            this.Oib = oib;
        }

        public Ucenik(string ime, string prezime, string oib, string racun) : this(ime, prezime, oib)
        {
            this.Racun = racun;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Oib { get => oib; set => oib = value; }
        public string Racun { get => racun; set => racun = value; }       
        public float Telefon { get => telefon; set => telefon = value; }
        public double PoStRacuna { get => poStRacuna; set => poStRacuna = value; }
        

        public double StanjeRacuna()
        {
            return PoStRacuna - 7200.00;
        }

    }
}