using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new GeneratorOfert();
            var oferty = generator.getOferty();

            for(int i = 0; i < oferty.Count;i++)
            {
                Console.WriteLine(oferty[i].toString());
            }
        }
    }
}
