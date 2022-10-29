using System;

namespace SzamKitalalo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Írjon programot, amelynek kezdetén adott egy pozitív egész szám, a „gondolt szám”. 
            //    A felhasználónak ki kell találnia, hogy mi a gondolt szám.Ehhez a felhasználó megadhat számokat, 
            //    melyekről a program megmondja, hogy a gondolt számnál nagyobbak vagy kisebbek-e.A program akkor ér véget, 
            //    ha a felhasználó kitalálta a gondolt számot. A program jelenítse meg a felhasználó próbálkozásainak számát is.

            Random random = new Random();

            int kitalalandoSzam = random.Next();

            int probakSzama = 0;
            int tipp = 0;

            while (kitalalandoSzam != tipp)
            {
                tipp = Convert.ToInt32(Console.ReadLine());

                if (tipp < kitalalandoSzam)
                {
                    Console.WriteLine("Túl kicsi");
                }
                else if (tipp > kitalalandoSzam)
                {
                    Console.WriteLine("Túl nagy");
                }

                probakSzama++;
            }

            Console.WriteLine($"Sikerult {probakSzama} kísérlet után kideríteni.");
        }
    }
}
