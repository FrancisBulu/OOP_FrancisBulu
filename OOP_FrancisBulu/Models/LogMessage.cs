using System;

namespace OOP_FrancisBulu.Models
{
    public class LogMessage
    {
        //properties
        public string Boodschap { get; set; }
        public int ID { get; set; }
        //constructor
        protected int GenID()
        {
            return (new Random()).Next(100);
        }
        protected LogMessage(string boodschap)
        {
            Boodschap = boodschap;
            ID = GenID();
        }
    }
}