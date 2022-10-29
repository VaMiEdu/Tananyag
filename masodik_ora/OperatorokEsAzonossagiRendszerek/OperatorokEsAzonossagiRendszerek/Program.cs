using System;

namespace OperatorokEsAzonossagiRendszerek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operatorok , logikai kapuk
            
            int szam = 8;

            bool szamOszthatoHarommal = (szam % 3 == 0);
            bool szamOszthatoNeggyel = (szam % 4 == 0);
            bool szamOszthatoKilenccel = (szam % 9 == 0);

            if (szamOszthatoHarommal)
            {
                Console.WriteLine("A szam osztható hárommal.");
            }

            if (szamOszthatoHarommal || szamOszthatoNeggyel)
            {
                Console.WriteLine("A szám osztható hárommal vagy néggyel.");
            }

            if (szamOszthatoHarommal && szamOszthatoNeggyel)
            {
                Console.WriteLine("A szám osztható hárommal és néggyel.");
            }

            if (szamOszthatoHarommal && szamOszthatoNeggyel && szamOszthatoKilenccel)
            {
                Console.WriteLine("A szám osztható hárommal, néggyel, illetve kilenccel is.");
            }


            // szökőév determinálása
            //Szökőévek a 4 - gyel osztható évek, kivéve a százzal oszthatóak, viszont a 400 - zal is oszthatóak szökőévek.

            int ev = Convert.ToInt16(Console.ReadLine());

            bool oszthatoNeggyel = ev % 4 == 0;
            bool oszthatoSzazzal = ev % 100 == 0;
            bool oszthatoNegySzazzal = ev % 400 == 0;

            if ((oszthatoNeggyel && !oszthatoSzazzal) || oszthatoNegySzazzal)
            {
                Console.Write($"{ev} év szökőév.");
            }
            else
            {
                Console.Write($"{ev} év NEM szökőév.");
            }

            //logikai kapuk gyakorlas

            //Console.WriteLine((3 < 4 || false) && (false || true));
            //Megoldása:
            //(true) && (true) -->  true

            //Console.WriteLine(true || !(true || false));
            //Megoldása:
            //true || !(true)  -->  true || false --> true

            //Console.WriteLine(false && (5 > 1 * 1 || 7 - 10 > -100));
            //Megoldása:
            //false && (true || true) -->  false && true -->  false


            //Magyarázat:
            // logikai 'ÉS': akkor lesz igaz, ha mindkét oldal igaz.
            //logikai 'VAGY': akkor lesz igaz, ha legalább az egyik oldal igaz.
        }
    }
}
