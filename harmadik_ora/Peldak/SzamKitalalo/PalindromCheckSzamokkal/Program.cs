using System;

namespace PalindromCheckSzamokkal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vizsgalandoSzam = 101;

            int forditottSzamsor = 0;
            int utolsoSzamjegy = 0;
            int temp = vizsgalandoSzam;

            while (temp > 0)
            {
                utolsoSzamjegy = temp % 10;
                forditottSzamsor = forditottSzamsor * 10 + utolsoSzamjegy;  // 10 -> 100
                temp = temp / 10;   // 100 -> 10
            }
        }
    }
}
