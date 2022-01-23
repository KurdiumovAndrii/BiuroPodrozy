using System;
using System.Collections.Generic;
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
                new Hotel("Hiszpania","Playacalida",600m, "******"),
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


            var dateStart = new DateTime(2022, 6, 15);
            var dateEnd = new DateTime(2022, 6, 22);
            var hotel = new Hotel("Meksyk", "Cancun Bay Resort", 450m, "****");
            var oferta = new Oferta(1, hotel, dateStart, dateEnd, true);

            oferty.Add(oferta);

            return oferty;
        }
    }
}
