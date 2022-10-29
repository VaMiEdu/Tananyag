using System;
using System.Linq;

namespace OsszesKozosOszto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam = Convert.ToInt32(Console.ReadLine());

            int[] osszesOszto = OsszesOszto(szam);

            foreach (var oszto in osszesOszto)
            {
                if (oszto > 0)
                {
                    Console.WriteLine(oszto);
                }
            }
        }

        public static int[] OsszesOszto(int szam)
        {
            int[] osztok = new int[szam];
            int indexer = 0;

            for (int i = szam; i > 0; i--)
            {
                if (szam % i == 0)
                {
                    osztok[indexer] = i;
                    indexer++;
                }

            }

            return osztok;
        }
    }
}
