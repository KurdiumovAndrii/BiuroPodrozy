using System;
namespace Project
{
    public class Hotel
    {
        public string kraj;
        public string nazwa;
        public decimal cenaZaDobe;
        public string kategoria;
        
        public Hotel(string kraj, string nazwa,decimal cenaZaDobe,string kategoria)
        {
            this.kraj = kraj;
            this.nazwa = nazwa;
            this.cenaZaDobe = cenaZaDobe;
            this.kategoria = kategoria;
        }
    }
}
