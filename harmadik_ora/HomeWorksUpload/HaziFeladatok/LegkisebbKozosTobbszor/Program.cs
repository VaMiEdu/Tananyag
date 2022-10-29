using System;

namespace LegkisebbKozosTobbszor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam1 = Convert.ToInt32(Console.ReadLine());
            int szam2 = Convert.ToInt32(Console.ReadLine());

            int kisebbSzam = szam1 < szam2 ? szam1 : szam2;
            int nagyobbSzam = szam1 > szam2 ? szam1 : szam2;

            int legkisebbKozosTobbszoros = LegkisebbKozosTobbszoros(kisebbSzam, nagyobbSzam);
        }

        private static int LegkisebbKozosTobbszoros(int kisebbSzam, int nagyobbSzam)
        {
            for (int i = 0; i <= kisebbSzam; i++)
            {
                int x = i * kisebbSzam;

                if (x % nagyobbSzam == 0)
                {
                    return x;
                }
            }

            return kisebbSzam * nagyobbSzam;
        }
    }
}
