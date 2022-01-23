using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateStart = new DateTime(2022, 6, 15);
            var dateEnd = new DateTime(2022, 6, 22);
            var hotel = new Hotel("Meksyk", "Cancun Bay Resort", 450m, "****");
            var oferta = new Oferta(1, hotel, dateStart, dateEnd, true);
            Console.WriteLine(oferta.toString());
        }
    }
}
