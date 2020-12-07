using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FrancisBulu.Models
{
    public class Cruise : Reis
    {
        //constante
        private const double CRUISEPRIJSEXTRADAGKOST = 10.00;
        //Properties
        private static bool VIP { get; set; } //kan enkel vanuit deze class zelf ingesteld worden
        //constructor
        public Cruise(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen) : base(vertrekDatum, terugkeerDatum, aantalPersonen)
        {

        }
        //methodes
        public override double BerekenPrijs()
        {
            double prijsCruise = base.BerekenPrijs() + CRUISEPRIJSEXTRADAGKOST * AantalPersonen;
            if (VIP == true)
            {
                return prijsCruise * 1.5;
            }
            else
            {
            return prijsCruise;
            }
        }
    }
}
