namespace _8._1_Proizvod
{
    internal class Proizvod
    {     
              
        public string naziv = "";
        public double cijena = 0;
        public double marza = 0;
        public double porez = 0;


        public double Mpc()
        {
            return cijena + marza +porez;
        }


    }
      
}