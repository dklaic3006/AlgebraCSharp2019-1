using System;

namespace _1_ucenik
{
    internal class Ucenik
    {
        private string ime;
        private string prezime;
        private string oib;
        private int racun;
        private float telefon;
        double poStRacuna;
        

        public Ucenik(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }

        public Ucenik(string ime, string prezime, string oib) : this(ime, prezime)
        {
            this.Oib = oib;
        }

        public Ucenik(string ime, string prezime, string oib, int racun) : this(ime, prezime, oib)
        {
            this.SetRacun(racun);
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Oib { get => oib; set => oib = value; }

        public int GetRacun()
        {
            return racun;
        }

        public void SetRacun(int value)
        {
            if (racun != null)
            {
                racun = value;
            }
            else
            {
                Random rng = new Random();
                int randomNumber = rng.Next(2000, 6000);
                racun = randomNumber;
            }

        }
        
        public float Telefon { get => telefon; set => telefon = value; }
        public double PoStRacuna { get => poStRacuna; set => poStRacuna = value; }

        //public double StanjeRacuna1 { get => StanjeRacuna; set => StanjeRacuna = value; }

        public double StanjeRacuna()
        {
            return PoStRacuna - 7200.00;
        }

    }
}