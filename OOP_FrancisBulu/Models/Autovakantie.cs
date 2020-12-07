using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FrancisBulu.Models
{
    public class Autovakantie : Reis
    {
        //constante
        private const double EXTRAPRIJSHUURAUTO = 10.00;
        //properties
        private static bool EigenWagen { get; set; } //kan enkel vanuit deze class zelf ingesteld worden
        //contructor
        public Autovakantie(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen) : base(vertrekDatum, terugkeerDatum, aantalPersonen)
        {

        }
        //methodes
        public override double BerekenPrijs()
        {
            double prijsAutovakantie = base.BerekenPrijs() * EXTRAPRIJSHUURAUTO;
            return prijsAutovakantie;
        }
    }
}
