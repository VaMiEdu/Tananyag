using System;
using System.Linq;

namespace PalindromCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "apa";

            string forditottSzoveg = string.Empty;

            foreach (var karakter in szoveg)
            {
                forditottSzoveg = karakter + forditottSzoveg;
            }

            forditottSzoveg = (string)szoveg.Reverse();

            if (szoveg.Equals(forditottSzoveg))
            {
                Console.WriteLine("Palindrom.");
            }
            else
            {
                Console.WriteLine("Nem palindrom.");
            }

            //tombokkel

            char[] szoveg1 = szoveg.ToCharArray();
            char[] forditott = new char[szoveg1.Length];

            int temp = szoveg1.Length;

            for (int i = 0; i < szoveg1.Length; i++)
            {
                forditott[temp - 1] = szoveg1[i];
                temp--;
            }


            //Console.WriteLine("Írjon be egy szót!");
            //String bekertAdat = Console.ReadLine();
            //String forditott;

            //char[] adat = bekertAdat.ToCharArray();

            //Array.Reverse(adat);

            //forditott = new string(adat);

            //bool check = bekertAdat.Equals(forditott);

            //if (check == true)
            //{
            //    Console.WriteLine($"{bekertAdat} egy Palidrom");
            //}
            //else
            //{
            //    Console.WriteLine($"{bekertAdat} nem Palidrom");
            //}
            //Console.Read();

        }

    }
}
