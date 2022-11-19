using System;

namespace Rekurzio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int osszeg = 0;

            for (int i = 0; i < 5; i++)
            {
                osszeg = osszeg + 1;
            }

            int valami = Rekurzio(5);

            int piramis = MunkahelyiPiramis(3);

            int fibonacci = Fibonacci(5);
        }

        static int Rekurzio(int n)
        {
            if (n >= 1) return 1 + Rekurzio(n - 1);
            else return 0;
        }


        static int MunkahelyiPiramis(int szam)
        {
            if (szam >= 1) return szam + MunkahelyiPiramis(szam - 1);
            else return 0;
        }

        // 0 0 1 1 2 3 5 8 13

        static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

    }
}
