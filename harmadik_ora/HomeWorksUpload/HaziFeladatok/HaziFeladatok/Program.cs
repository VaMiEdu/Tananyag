using System;

namespace HaziFeladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam = Convert.ToInt32(Console.ReadLine());

            int[] osszesOszto = OsszesOszto(szam);
        }

        private static int[] OsszesOszto(int szam)
        {
            int[] osztok = new int[szam];
            int indexer = 0;

            for (int i = szam; i > 0; i--)
            {
                if (szam % i ==0)
                {
                    osztok[indexer] = i;
                    indexer++;
                }
            }
        
            return osztok;
        }
    }
}
