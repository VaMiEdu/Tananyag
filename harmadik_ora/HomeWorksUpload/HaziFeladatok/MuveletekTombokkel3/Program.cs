using System;
using System.Linq;

namespace MuveletekTombokkel3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kérj be a felhasználótól hónapnevet! Egészen addig ne fogadja el a bemenetet, amíg tényleg hónapnevet nem ír be.
            //(Ellenőrizze: a hónapneveket tömbben tárolja, ha a felhasználó bemenete nem szerepel ebben, akkor kérje újra.)

            string[] honapNevek = {
                "január",
                "február",
                "március",
                "április",
                "május",
                "június",
                "július",
                "augusztus",
                "október",
                "november",
                "december" };

            HonapNevEllenorzese(honapNevek);
        }

        private static void HonapNevEllenorzese(string[] honapNevek)
        {
            bool validHonapNev = false;

            do
            {
                string bekertAdat = Console.ReadLine();

                validHonapNev = honapNevek.Contains(bekertAdat);

                if (validHonapNev)
                {
                    Console.WriteLine("Megfelelo honapnev");
                    
                }

            } while (validHonapNev);
        }
    }
}
