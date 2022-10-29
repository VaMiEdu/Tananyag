using System;

namespace MuveletekTombokkel1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hozz létre egy int típusú tömbböt, melyeknek értékeit a következőek legyenek: 1,2,3,4,5,6,7,8,9,10.

            int[] tomb = new int[10];

            for (int i = 0; i < 10; i++)
            {
                tomb[i] = i + 1;
            }

            //- Írasd ki a tömb elemeit a consolra.
            TombKiiratas(tomb);

            //-Fordítsd meg a tömb sorrendjét, majd írasd ki az elemeit consolra.

            Array.Reverse(tomb);
            TombKiiratas(tomb);

            //- Határozd meg a tömb elemeinek összegét és írasd ki az eredményt.
            int osszeg = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }

            TombKiiratas(tomb);

            //-Határozza meg a tömb legkisebb értékének indexét!

            int legkisebb = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[legkisebb] > tomb[i])
                {
                    legkisebb = i;
                }
            }
        }


        private static void TombKiiratas(int[] tomb)
        {
            foreach (var elem in tomb)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
