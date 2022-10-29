using System;

namespace MuveletekTombokkel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hozz létre egy int típusú 100 elemből álló tömbök, melyet tölts fel random(véletlenszerű) számokkal.

            //Segítség a véletlenszám-generáláshoz:
            //Random R = new Random();
            //int veletlenSzam = R.Next(0, 101);

            int[] tomb = new int[100];

            Console.WriteLine("A tömb véletlenszerűen feltöltött értékei a következők:");
            tombRandomizalas(tomb);

            static void tombRandomizalas(int[] tomb)
            {
                Random R = new Random();
                for (int i = 0; i < 100; i++)
                {
                    tomb[i] = R.Next(0, 101);
                }
            }

            for (int i = 0; i < 100; i++)
            {
                Console.Write(tomb[i]);
                Console.Write(" ");
            }
            Console.Write("\n\n");


            //-Határozd meg, hogy szerepel-e a tömbben 5 - tel sztható szám.

            Console.WriteLine("A tömb öttel osztahó (nem nulla) értékei:");
            bool vanOttelOszthato = false;
            for (int i = 0; i < 100; i++)
            {
                if ((tomb[i] != 0) && (tomb[i] % 5 == 0))
                {
                    vanOttelOszthato = true;
                    Console.Write(tomb[i]);
                    Console.Write(" ");

                    // return true
                }
            }
            Console.Write("\n");
            if (vanOttelOszthato) Console.WriteLine("Tehát van legalább egy öttel osztható értéke.");
            else Console.WriteLine("Tehát egyetlen öttel osztható értéke sincs.");
            Console.Write("\n");


            //-Hány darab 2 - vel osztható szám van a tömbben ?
            Console.WriteLine("A tömb kettővel osztahó (nem nulla) értékei:");
            int kettovelOszthato = 0;
            for (int i = 0; i < 100; i++)
            {
                if ((tomb[i] != 0) && (tomb[i] % 2 == 0))
                {
                    kettovelOszthato++;
                    Console.Write(tomb[i]);
                    Console.Write(" ");
                }
            }
            Console.Write("\n");
            Console.WriteLine("A tömb kettővel osztható értékeinek száma tehát:");
            Console.WriteLine(kettovelOszthato);
            Console.Write("\n");


            //-Készíts egy int típusú metódust, ami egy int[] típust vár és viszzaadja a tömb legkisebb értékének az indexét.

            //Segítség a metódus implementációjához:
            //public int LegkisebbErtekIndexe(int[] tomb)
            //{
            //    int legkisebbErtekIndexe = -1;

            //    //Implementálandó logika

            //    return legkisebbErtekIndexe;
            //}

            Console.WriteLine("A tömb legkisebb értékének indexe:");
            Console.WriteLine(legkisebbErtekIndexe(tomb));
            Console.Write("\n");

            static int legkisebbErtekIndexe(int[] tomb)
            {
                int legkisebbErtekIndexe = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (tomb[legkisebbErtekIndexe] > tomb[i])
                    {
                        legkisebbErtekIndexe = i;
                    }
                }
                return legkisebbErtekIndexe;
            }


            //- Készíts egy int típusú metódust, ami egy int[] típust vár és visszadja az indexét az első olyan számnak a tömbben, ami osztható kettővel.Ha nincs 2-vel osztható szám a tömbben, adjon vissza -1 -et.

            Console.WriteLine(elsoKettovelOszthatoErtekIndexe(tomb));

            static int elsoKettovelOszthatoErtekIndexe(int[] tomb)
            {
                int elsoKettovelOszthatoErtekIndexe = -1;

                for (int i = 0; i < 100; i++)
                {
                    if (tomb[i] % 2 == 0)
                    {
                        elsoKettovelOszthatoErtekIndexe = i;
                        break;
                    }
                }
                if (elsoKettovelOszthatoErtekIndexe == -1)
                    Console.WriteLine("A tömbnek nincs kettővel osztható tagja.");
                else
                    Console.WriteLine("A tömb első kettővel osztható értékének indexe:");
                return elsoKettovelOszthatoErtekIndexe;
            }
        }
    }
}
