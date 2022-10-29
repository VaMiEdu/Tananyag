using System;

namespace Tombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok;
            szamok = new int[3];

            //Egy sorban is lehet:
            //int[] szamok = new int[3];  

            szamok[0] = 9;
            szamok[1] = 5;
            szamok[2] = 6;

            //Egy adott elem kiiratása
            Console.WriteLine(szamok[0]);

            //Tömb kapacitása
            int szamokKapacitasa = szamok.Length;

            Console.WriteLine($"A szamok tömb elso erteke: {szamok[0]}");
            Console.WriteLine(szamokKapacitasa);

            //----------------------------------------------------------------------

            string[] nevek = new string[3];

            nevek[0] = "Pista";
            nevek[1] = "Mariska";
            nevek[2] = "Peti";

            // végig iterálás az elemeken for ciklussal
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]);
            }

            // végig iterálás az elemeken foreach metódussal
            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }

            //Sorrend megcserélése
            Array.Reverse(nevek);

            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }

            foreach (var szam in szamok)
            {
                Console.WriteLine(szam);
            }

            //Növekvő sorrendbe rendezés
            Array.Sort(szamok);

            foreach (var szam in szamok)
            {
                Console.WriteLine(szam);
            }

            int[] evSzamok = new int[3];

            //Tömb feltöltése adatokkal
            for (int i = 0; i < 3; i++)
            {
                evSzamok[i] = Convert.ToInt16(Console.ReadLine());
            }

            Array.Sort(evSzamok);

            foreach (var ev in evSzamok)
            {
                Console.WriteLine(ev);
            }

            Array.Reverse(evSzamok);

            foreach (var ev in evSzamok)
            {
                Console.WriteLine(ev);
            }

            Console.ReadLine();

            //----------------------------------------------------------------------
            
            int[] numbers = new int[3];
            bool vanOttelOszthato = false;
            int sum = 0;

            //Tömb feltöltése számokkal
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = Convert.ToInt16(Console.ReadLine());
            }

            //Derítsük ki, hogy van-e öttel osztható szám a tömbben
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 5 == 0)
                {
                    vanOttelOszthato = true;
                }
            }

            //Tömb elemeinek összeadása
            foreach (var number in numbers)
            {
                sum += number;
            }

            if (vanOttelOszthato)
            {
                Console.WriteLine("Van ottel oszthato szam a tömbben.");
            }
            else
            {
                Console.WriteLine("Nincs ottel oszthato szam a tömbben");
            }

            Console.WriteLine($"A tömbben található számok összege: {sum}");
            
            //----------------------------------------------------------------------
            
            //Számok feltöltése a felhasználótól bekért adatokkal és számok összeadása
            int counter = 0;  
            int[] szamok1 = new int[5];
            int osszeg = 0;
            do
            {
                Console.Write("Adj meg egy szamot:");
                int szam = Convert.ToInt32(Console.ReadLine());
                szamok1[counter] = szam;
                osszeg += szam;
                counter++;
            } while (counter < 5);

            Console.WriteLine("Az 5 szam osszege:" + osszeg);


            // Találjuk meg az öttel osztható számokat a tömbben
            foreach (var szam in szamok1)
            {
                if (szam % 5 == 0)
                {
                    Console.WriteLine("A tombben a kovetkezo szam oszthato 5-tel:" + szam);
                }
            }
        }
    }
}
