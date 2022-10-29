using System;

namespace Metodusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szem = "szem";
            string uveg = "üveg";

            string szemUveg = szovegekOsszeIllesztese(szem, uveg);

            Console.WriteLine("szemUveg");

            static string szovegekOsszeIllesztese(string elsoSzoveg, string masodikSzoveg)
            {
                string vegEredmeny = $"{elsoSzoveg} {masodikSzoveg}";
                return vegEredmeny;
            }

            //------------------------------------------------------------------------------------------

            int bekertSzam = Convert.ToInt32(Console.ReadLine());

            //if (bekertSzam % 9 == 0)
            //{
            //    Console.WriteLine("Oszthato ezzel: 9 .");
            //}

            //if (bekertSzam % 4 == 0)
            //{
            //    Console.WriteLine("Oszthato ezzel: 4.");
            //}

            //if (bekertSzam % 3 == 0)
            //{
            //    Console.WriteLine("Oszthato ezzel 3.");
            //}

            OszthatosagEllenorzese(bekertSzam, 9);
            OszthatosagEllenorzese(bekertSzam, 4);
            OszthatosagEllenorzese(bekertSzam, 3);

            static void OszthatosagEllenorzese(int osztandoSzam, int oszto)
            {
                if (osztandoSzam % oszto == 0)
                {
                    Console.WriteLine($"Oszthato ezzel: {oszto} .");
                }
            }

            //------------------------------------------------------------------------------------------


            string[] tetelekNevei = new string[5];
            int[] tetelekMennyisege = new int[5];

            AdatokBekerese(tetelekNevei, tetelekMennyisege);
            TetelInformaciokKiiratasa(tetelekNevei, tetelekMennyisege);
            
            static void AdatokBekerese(string[] nevek, int[] mennyisegek)
            {
                for (int i = 0; i < 5; i++)
                {
                    nevek[i] = Console.ReadLine();
                    mennyisegek[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            static void TetelInformaciokKiiratasa(string[] nevek, int[] mennyisegek)
            {
                for (int i = 0; i < nevek.Length; i++)
                {
                    Console.WriteLine(nevek[i]);
                    Console.WriteLine(mennyisegek[i]);
                }
            }
        }
    }
}
