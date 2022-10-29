using System;

namespace MuveletekTombokkel3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kérj be a felhasználótól hónapnevet! Egészen addig ne fogadja el a bemenetet, amíg tényleg hónapnevet nem ír be.
            //(Ellenőrizze: a hónapneveket tömbben tárolja, ha a felhasználó bemenete nem szerepel ebben, akkor kérje újra.)
            //string[] honapNevek = new string[12];

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



            honapNevVerifikalo(honapNevek);

            static void honapNevVerifikalo(string[] honapNevek)
            {
                Console.WriteLine("Adj meg egy hónapot!");

                string bekertHonapNev = Console.ReadLine();
                string lowerBekertHonapNev = bekertHonapNev.ToLower();
                bool honapNevValodi = false;

                for (int i = 0; i < honapNevek.Length; i++)
                {
                    if (lowerBekertHonapNev == honapNevek[i])
                    {
                        honapNevValodi = true;
                    }
                }

                if (honapNevValodi)
                    Console.WriteLine($"OK, a \"{lowerBekertHonapNev}\" megfelelő hónapnév.");
                else
                {
                    Console.WriteLine($"\"{lowerBekertHonapNev}\" nem megfelelő hónapnév. Kérlek próbáld újra!");
                    honapNevVerifikalo(honapNevek);
                }
            }
        }
    }
}
