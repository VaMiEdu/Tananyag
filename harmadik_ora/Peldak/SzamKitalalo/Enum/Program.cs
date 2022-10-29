using System;

namespace Enum
{
    internal class Program
    {
        public enum Napok { hétfő = 10, kedd = 20, szerda = 30, csütörtök = 40, péntek = 50, szombat = 60, vasárnap = 90 }

        static void Main(string[] args)
        {
            if (MaiNapDiscount() == Napok.szerda)
            {
                Console.WriteLine("Harminc Százalékos akció");
            }
        }

        public static Napok MaiNapDiscount()
        {
            return Napok.szerda;
        }

    }
}
