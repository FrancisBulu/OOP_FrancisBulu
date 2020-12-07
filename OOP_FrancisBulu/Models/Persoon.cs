namespace OOP_FrancisBulu.Models
{
    public class Persoon
    {
        public Adres Adres { get; set; }
        public string FamilieNaam { get; set; }
        public string Naam 
        {
            get {return $"{Voornaam} {FamilieNaam}"; } //readonly
        }
        public string Voornaam { get; set; }
    }
}