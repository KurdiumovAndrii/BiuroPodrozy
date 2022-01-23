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
                new Hotel("Meksyk","Iberostar Quetzal",690m, 5),
            };

            return hotels;
        }
    }
}
