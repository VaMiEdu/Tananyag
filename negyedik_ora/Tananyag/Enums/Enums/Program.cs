using System;

namespace Enums
{
    enum AkciosNapok { Hetfo = 10, Kedd = 20, Szerda = 30, Csutortok = 40, Pentek = 50, Szombat = 60, Vasarnap = 90 }

    internal class Program
    {
        static void Main(string[] args)
        {
            const int konstans = 10;


            var nap = AkciosNapok.Hetfo;

            switch (nap)
            {
                case AkciosNapok.Hetfo:
                    Console.WriteLine( $"{(int)AkciosNapok.Hetfo} szazalek akcio" );
                    break;
                case AkciosNapok.Kedd:
                    Console.WriteLine($"{(int)AkciosNapok.Kedd} szazalek akcio");
                    break;
                default:
                    break;
            }

        }
    }
}
