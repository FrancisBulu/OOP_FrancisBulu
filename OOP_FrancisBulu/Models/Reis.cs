using System;

namespace OOP_FrancisBulu.Models
{
    public abstract class Reis
    {
        private const double BASISDAGPRIJS = 40.00;
        public TimeSpan AantalDagen 
        {
            get 
            {
                return  TerugkeerDatum - VertrekDatum;
            }
        }
        public int AantalPersonen { get; set; }
        public DateTime VertrekDatum
        {
            get
            {
                return VertrekDatum;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    Console.WriteLine("Vertreek datum kan niet in het verleden liggen");
                }
                else if (value > TerugkeerDatum)
                {
                    Console.WriteLine("Vertreek datum kan niet na terug datum liggen");
                }
                else
                {
                    VertrekDatum = value;
                }
            }
        }
        public DateTime TerugkeerDatum
        {
            get
            {
                return TerugkeerDatum;
            }
            set 
            {
                DateTime vertrekDatum = default;
                if (value < DateTime.Now)
                {
                    Console.WriteLine("Terugkeer datum kan niet in het verleden liggen");
                }
                else if (vertrekDatum > value)
                {
                    Console.WriteLine("Terugkeer datum kan niet voor het vertreek datum liggen");
                }
                else
                {
                    TerugkeerDatum = value;
                }
             }
        }
        //methodes
        public virtual double BerekenPrijs()
        {
            double Prijs = BASISDAGPRIJS * AantalDagen.Days;
            return Prijs;
        }
        public Reis(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen)
        {

        }
    }
}