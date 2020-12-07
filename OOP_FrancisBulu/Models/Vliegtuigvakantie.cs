using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FrancisBulu.Models
{
    public class Vliegtuigvakantie : Reis
    {
        //properties
        private double VliegtuigTicketPrijs { get; set; }
        //constructor
        public Vliegtuigvakantie(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen) : base(vertrekDatum, terugkeerDatum, aantalPersonen)
        {

        }

        //methodes
        public override double BerekenPrijs()
        {
            double prijsVliegtuig = base.BerekenPrijs() + VliegtuigTicketPrijs;
            return prijsVliegtuig;
        }
    }
}
