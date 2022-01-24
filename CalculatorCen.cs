using System;
namespace Project
{
    public class CalculatorCen
    {

        public CalculatorCen()
        {

        }

        public void pracaZuzytkownikom()
        {
            var generator = new GeneratorOfert();
            var oferty = generator.getOferty();

            decimal konecznaCena;
            for (int i = 0; i < oferty.Count; i++)
            {
                Console.WriteLine(oferty[i].toString());
            }
            Console.WriteLine("PROSZĘ PODAĆ NUMER WYBRANEJ OFERTY: ");
            int numerOferty = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ OSÓB DOROSŁYCH: ");
            int doroslych = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ DZIECI: ");
            int dzieci = Convert.ToInt32(Console.ReadLine());


            var wybranaOferta = oferty[numerOferty - 1];

            konecznaCena = doroslych * wybranaOferta.cena + (dzieci * (wybranaOferta.cena / 2));

            Console.Clear();

            Console.WriteLine("CAŁKOWITA CENA WAKACJI WYNOSI: " + konecznaCena);
         
        }
    }
}
