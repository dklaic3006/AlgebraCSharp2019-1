namespace _8._1._2_Automobil
{
    internal class Automobil
    {
        //public Automobil();
        
        public string markaAutomobila = "";
        public double osnovnaCijena = 0;
        public double snaga = 0;


        public double Uk_cijena()
        {
            return osnovnaCijena + Porez();

            //throw new NotImplementedException();
        }

        public double Porez()
        {
            double porez = 0;
            if (snaga < 50)
            {
                porez = osnovnaCijena * 0.05;
            }
            else if (snaga >= 50 || snaga < 150)
            {
                porez = osnovnaCijena * 0.1;
            }
            else
            {
                porez = osnovnaCijena * 0.15;
            }
            
            return porez;
        }

    }
}