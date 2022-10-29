using System;

namespace KozosTobbszoros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam1 = Convert.ToInt32(Console.ReadLine());
            int szam2 = Convert.ToInt32(Console.ReadLine());

            int kisebbSzam = szam1 < szam2 ? szam1 : szam2;  // conditional operator (ternary conditional operator)
            int nagyobbSzam = szam1 > szam2 ? szam1 : szam2;

            int legkisebbKozosTobbszoros = LegKisebbKozosTobbszoros(kisebbSzam, nagyobbSzam);
        }

        static int LegKisebbKozosTobbszoros(int kisebbSzam, int nagyobbSzam)
        {
            for (int i = 1; i <= kisebbSzam; i++)
            {
                int res = i * kisebbSzam;

                if (res % nagyobbSzam == 0)
                {

                    return res;
                }
            }

            return kisebbSzam * nagyobbSzam;
        }
    }
}
