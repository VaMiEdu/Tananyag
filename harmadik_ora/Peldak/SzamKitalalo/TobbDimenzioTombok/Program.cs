using System;
using System.Collections.Generic;

namespace TobbDimenzioTombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tomb = new int[3, 3];

            int[,] tomb2 = new int[,]
            {
                { 1 , 2 , 3 },
                { 4 , 5 , 6 },
                { 7 , 8 , 9 }
            };

            var tomb3 = tomb2;  // a tomb3 referenciája a tomb2-re fog mutatni

            foreach (var adottElem in tomb2)
            {
                Console.WriteLine(adottElem);
            }

            int elsoErtek = tomb2[2, 1];


            for (int i = 0; i < tomb2.GetLength(0); i++)
            {
                for (int j = 0; j < tomb2.GetLength(1); j++)
                {
                    Console.Write(tomb2[i, j]);
                }

                Console.WriteLine();
            }

            var ujTomb = new int[tomb2.GetLength(0), tomb2.GetLength(1)];

            for (int i = 0; i < tomb2.GetLength(0); i++)
            {
                for (int j = 0; j < tomb2.GetLength(1); j++)
                {
                    ujTomb[i, j] = tomb2[i, j];
                }
            }

            //-----------------------------------------------------------------------------
            //3x3 - async tomb 3.oszlopaban hany paros szám található?

            var tomb4 = new int[3, 3];
            var counter = 0;

            //sorok körbejárása
            for (int i = 0; i < tomb4.GetLength(0); i++)
            {
                //oszlopok körbejárása
                for (int j = 0; j < tomb4.GetLength(1); j++)
                {
                    tomb4[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < tomb4.GetLength(1); i++)
            {
                if (tomb4[i, 2] % 2 == 0)
                {
                    counter++;
                }
            }

            //jagged array

            var jaggedArray = new int[][]
            {
                new int[] { 1,2,3 },
                new int[] { 2,3,4 },
                new int[] { 3,4,5 }
            };

            foreach (var tomb5 in jaggedArray)
            {
                foreach (var aktualisElem in tomb)
                {
                    Console.WriteLine(aktualisElem);
                }
            }

            int[] tomb6 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] tomb7 = new int[6];


            //ctrl + shift + space -> intellisense popup window
            tomb7 = (int[])tomb6.Clone();

            tomb6.CopyTo(tomb7, 1);

            //-----------------------------------------------------------------------------
            //Lists

            List<string> lista = new List<string>();

            lista.Add("alma");
            lista.Add("körte");
            lista.Add("barack");
            lista.Add("szilva");

            lista[0] = "asd";



            foreach (var aktualisElem in lista)
            {
                Console.WriteLine(aktualisElem);
            }

            var lista2 = new List<string>() { "egy", "ketto" };

            string szoveg = "valami";

            var karakterTomb = szoveg.ToCharArray();

            var listakent = new List<char>(karakterTomb);

            List<int> szamokListaja = new List<int>() { 1, 2, 3, 4, 5, 6 };

            List<int> szamok2 = new List<int>();

            szamok2.AddRange(szamokListaja);

            lista.Remove("alma");
            lista.Remove(lista[0]);

            szamok2.RemoveAt(0);

            szamok2.RemoveAll(x => x > 5);

            szamok2.RemoveRange(2, 2);

            var gyumik = new List<string>();
            string bekertAdat;
            var kilepesiFeltetel = "exit";

            do
            {
                bekertAdat = Console.ReadLine();

                if (gyumik.Contains(bekertAdat))
                {
                    Console.WriteLine("letezo elem");
                }
                else
                {
                    gyumik.Add(bekertAdat);
                }

            } while (bekertAdat != kilepesiFeltetel);

            Console.WriteLine("A gyümölcsöket tartalmazó lista elemei:");

            foreach (var item in gyumik)
            {
                Console.WriteLine(item);
            }
        }
    }
}
