using System;

namespace Muveletek_Tombokkel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hozz létre egy int típusú 100 elemből álló tömbök, melyet tölts fel random(véletlenszerű) számokkal.

            int[] tomb = new int[100];

            Random r = new Random();

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(0, 101);
            }

            //-Határozd meg, hogy szerepel-e a tömbben 5 - tel sztható szám.
            TartalmazEOttelOszthatoSzamot(tomb);

            //-Hány darab 2 - vel osztható szám van a tömbben ?

            int kettovelOszthatokSzama = KettovelOszthatokSzama(tomb);

            //-Készíts egy int típusú metódust, ami egy int[] típust vár és viszzaadja a tömb legkisebb értékének az indexét.

            int legkisebbErtekIndexe = LegkisebbErtekIndexe(tomb);

            //-Készíts egy int típusú metódust, ami egy int[] típust vár és visszadja az indexét az első olyan 
            //    számnak a tömbben, ami osztható kettővel.Ha nincs 2 - vel osztható szám a tömbben, adjon vissza - 1 - et.

            int elsoKettovelOszthato = FindElsoKettovelOszthato(tomb);
        }

        private static int FindElsoKettovelOszthato(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        private static int LegkisebbErtekIndexe(int[] tomb)
        {
            int legkisebbErtekIndexe = 0;
            int jelenlegiLegkisebbErtek = tomb[0];

            for (int i = 0; i <= tomb.Length; i++)
            {
                if (tomb[i] < jelenlegiLegkisebbErtek)
                {
                    jelenlegiLegkisebbErtek = tomb[i];
                    legkisebbErtekIndexe = i;
                }
            }

            return legkisebbErtekIndexe;
        }

        private static bool TartalmazEOttelOszthatoSzamot(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 5 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static int KettovelOszthatokSzama(int[] tomb)
        {
            int kettovelOszthatokSzama = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    kettovelOszthatokSzama++;
                }
            }

            return kettovelOszthatokSzama;
        }
    }
}
