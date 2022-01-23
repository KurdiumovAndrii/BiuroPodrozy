using System;
using System.Collections.Generic;
namespace Project
{
    public class GeneratorOfert
    {

        public GeneratorOfert()
        {
        }

        List<Hotel> getHotels()
        {
            List<Hotel> hotels = new List<Hotel>() {
                new Hotel("Meksyk","Cancun Bay Resort", 450m, 4),
                new Hotel("Meksyk","Iberostar Quetzal",690m, 5),
                new Hotel("Meksyk","Imperial Laguna by Farada",320m, 3),
                new Hotel("Hiszpania","Playacalida",600m, 5),
                new Hotel("Hiszpania","Palia Puerto dedl Sol",240m, 3),
                new Hotel("Hiszpania","Playa Real Resort",380m, 4),
                new Hotel("Egipt","Sea Gull",270m, 3),
                new Hotel("Egipt","Continental Hurghada",360m, 4),
                new Hotel("Egipt","Sharm Grand Plaza",620m, 5),
                new Hotel("Grecja","Ikaros Hotel",220m, 3),
                new Hotel("Grecja","Labranda Sanddy Beach Resort",580m,5),
                new Hotel("Grecja","Lida Corfu",310m, 4),
                new Hotel("Tajlandia","Mytt Beach Hotel",720m, 5),
                new Hotel("Tajlandia","Novotel Rayong",410m, 4),
                new Hotel("Tajlandia","Cholchan Pattaya Resort",290m, 3),
            };

            return hotels;
        }
    }
}
