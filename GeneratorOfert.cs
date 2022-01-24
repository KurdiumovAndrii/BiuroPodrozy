using System;
using System.Collections.Generic;
using System.Linq;
namespace Project
{
    public class GeneratorOfert
    {

        public GeneratorOfert()
        {

        }

        public List<Hotel> getHotels()
        {
            List<Hotel> hotels = new List<Hotel>() {
                new Hotel("Meksyk","Cancun Bay Resort", 450m, "****"),
                new Hotel("Meksyk","Iberostar Quetzal",690m, "*****"),
                new Hotel("Meksyk","Imperial Laguna by Farada",320m, "***"),
                new Hotel("Hiszpania","Playacalida",600m, "*****"),
                new Hotel("Hiszpania","Palia Puerto dedl Sol",240m, "***"),
                new Hotel("Hiszpania","Playa Real Resort",380m, "****"),
                new Hotel("Egipt","Sea Gull",270m, "***"),
                new Hotel("Egipt","Continental Hurghada",360m, "****"),
                new Hotel("Egipt","Sharm Grand Plaza",620m, "*****"),
                new Hotel("Grecja","Ikaros Hotel",220m, "***"),
                new Hotel("Grecja","Labranda Sanddy Beach Resort",580m,"*****"),
                new Hotel("Grecja","Lida Corfu",310m, "****"),
                new Hotel("Tajlandia","Mytt Beach Hotel",720m, "*****"),
                new Hotel("Tajlandia","Novotel Rayong",410m, "****"),
                new Hotel("Tajlandia","Cholchan Pattaya Resort",290m, "***"),
            };

            return hotels;
        }

        public List<Oferta> getOferty()
        {
            var oferty = new List<Oferta>();

            var hotele = getHotels();

            var random = new Random();

            var uzyteKraje = new List<string>();
            var uzyteKategorie = new List<string>();
            var liczbaDni = new List<int>() { 7, 10, 14 };

            while (oferty.Count < 3)
            {
                var hotelIndex = random.Next(0, hotele.Count - 1);
                var hotel = hotele[hotelIndex];

                if (!uzyteKraje.Contains(hotel.kraj) && !uzyteKategorie.Contains(hotel.kategoria))
                {

                    bool allInclusive = false;
                    if (hotel.kategoria == "****" || hotel.kategoria == "*****")
                    {
                        allInclusive = true;
                    }
                    var randomLiczbaDni = random.Next(0,liczbaDni.Count - 1);
                    var liczba = liczbaDni[randomLiczbaDni];
                    liczbaDni.Remove(liczba);

                    var dataWylotu = new DateTime(2022, 6, 15);
                    var dataPowrotu = dataWylotu.AddDays(liczba);
                    var oferta = new Oferta( hotel, dataWylotu, dataPowrotu, allInclusive);
                    uzyteKategorie.Add(hotel.kategoria);
                    uzyteKraje.Add(hotel.kraj);
                    

                    oferty.Add(oferta);

                }
            }
            var sortowaneOferty = oferty.OrderBy(o => o.cena).ToList();

            for(int i = 0; i < sortowaneOferty.Count; i++)
            {
                sortowaneOferty[i].numer = i + 1;
            }
            return sortowaneOferty;
        }
    }
}
