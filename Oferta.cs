using System;
namespace Project
{
    public class Oferta
    {
        public Hotel hotel;
        public DateTime dataWylotu;
        public DateTime dataPowrotu;
        public bool allInclusive;
        public int numer;
        public decimal cena;
        public int liczbaDni;

        public Oferta( Hotel hotel, DateTime dataWylotu, DateTime dataPowrotu, bool allInclusive)
        {
            this.dataWylotu = dataWylotu;
            this.dataPowrotu = dataPowrotu;
            this.allInclusive = allInclusive;
            this.hotel = hotel;

            this.liczbaDni = (dataPowrotu - dataWylotu).Days;
            this.cena = hotel.cenaZaDobe * liczbaDni;
            

        }

       public string toString()
        {
            string wyzywienie;
            if(allInclusive == true)
            {
                wyzywienie = "All Inclusive";
            }
            else
            {
                wyzywienie = "Śniadania";
            }

            return
                "NUMER: " + this.numer + "\n" +
                "KRAJ: " + hotel.kraj + "\n" +
                "TERMIN: " + this.dataWylotu.ToShortDateString() + " - " + this.dataPowrotu.ToShortDateString() + " (" + this.liczbaDni + " dni)" + "\n" +
                "HOTEL: " + hotel.nazwa + " (" + hotel.kategoria + ")" + "\n" +
                "WYZYWIENIE: " + wyzywienie + "\n" +
                "CENA: " + cena + " PLN/os" + "\n" +
                "---------------------------------------" + "\n";
        }
    }
}
