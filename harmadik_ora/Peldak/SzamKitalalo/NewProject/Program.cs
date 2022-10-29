using System;

namespace OutEsRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam1 = 1;
            int szam2 = 2;

            Csere(ref szam1, ref szam2);

            Csere2(szam1, szam2, out int szam3);

            Console.WriteLine(szam3);
        }

        private static void Csere(ref int szam1, ref int szam2)  // a szám referenciáját adjuk át (pointer az adott memória területre, nem pedig az értéket másoljuk át.)
        {
            int temp = szam1;
            szam1 = szam2;
            szam2 = temp;
        }

        private static void Csere2(int szam1, int szam2, out int szam3)
        {
            int temp = szam1;
            szam1 = szam2;
            szam2 = temp;

            szam3 = 10000;
        }
    }
}
