using OOP_FrancisBulu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FrancisBulu.Models
{
    public class ReisReservatie : ILoggable
    {
        //properties
        public Reisbureau ReisBureau { get; set; }
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }
        public LogMessage LogMessage { get; set; }
        //constructor
        public ReisReservatie()
        {

        }

        //methode
        //public void ReisReservatie()
        //{
    
        //}
    }
}
