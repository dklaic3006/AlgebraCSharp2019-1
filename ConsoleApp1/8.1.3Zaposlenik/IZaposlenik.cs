namespace _8._1._3Zaposlenik
{
    internal interface IZaposlenik
    {
        double BrojBodova { get; set; }
        string Ime { get; set; }
        double Oib { get; set; }
        double Porez { get; }
        string Prezime { get; set; }
        double VrijednostBoda { get; set; }
    }
}