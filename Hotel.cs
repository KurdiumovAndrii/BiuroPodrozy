using System;
namespace Project
{
    public class Hotel
    {
        public string kraj;
        public string nazwa;
        public decimal cena;
        public int kategoria;
        
        public Hotel(string kraj, string nazwa,decimal cena,int kategoria)
        {
            this.kraj = kraj;
            this.nazwa = nazwa;
            this.cena = cena;
            this.kategoria = kategoria;
        }
    }
}
