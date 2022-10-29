using System;

namespace MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math class beépített metódusai

            int szam = 5;
            double szam2 = 10;
            double szog = 165.5;

            Math.Max(szam, szam2);
            Math.Min(szam, szam2);
            Math.Pow(szam, szam2);
            Math.Round(szam2);
            Math.Sqrt(szam2);

            Math.Sin(szog);
            Math.Cos(szog);
            Math.Tan(szog);

            //Kör kerülete és területe

            var sugar = 12;
            var kerulet = Math.PI * 2 * sugar;
            var terulet = Math.Pow(sugar, 2) * Math.PI;
        }
    }
}
