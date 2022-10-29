using System;
using System.Linq;

namespace MuveletekTombokkel1
{
    class Program
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
            Console.WriteLine("A tömb értékei:");
            kiiras(tomb);
            Console.Write("\n\n");

            static void kiiras(int[] tomb)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(tomb[i]);
                    Console.Write(" ");
                }
            }

            //-Fordítsd meg a tömb sorrendjét, majd írasd ki az elemeit consolra.
            Array.Reverse(tomb);
            Console.WriteLine("A tömb értékei fordított sorrendben:");
            kiiras(tomb);
            Console.Write("\n\n");

            //- Határozd meg a tömb elemeinek összegét és írasd ki az eredményt.
            Console.WriteLine("A tömb értékeinek összege:");
            Console.WriteLine(osszeg(tomb));
            Console.Write("\n");

            static int osszeg(int[] tomb)
            {
                int osszeg = 0;
                for (int i = 0; i < 10; i++)
                {
                    osszeg += tomb[i];
                }
                return osszeg;
            }

            //-Határozza meg a tömb legkisebb értékének indexét!
            Console.WriteLine("A tömb legkisebb értékének indexe:");
            Console.WriteLine(legkisebb(tomb));

            int legkisebb(int[] tomb)
            {
                int legkisebb = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (tomb[legkisebb] > tomb[i])
                    {
                        legkisebb = i;
                    }
                }
                return legkisebb;
            }
        }
    }
}