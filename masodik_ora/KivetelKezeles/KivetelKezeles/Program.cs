using System;

namespace KivetelKezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hibakezelés / kivetelkezeles 

            string szoveg = "Ez nem egy szam típus";
            int szam;

            try
            {
                szam = Convert.ToInt32(szoveg);
            }
            catch (Exception)
            {
                Console.WriteLine("valamilyen hiba történt.");
            }

            //----------------------------------------------------------------

            var oszto = Convert.ToInt32(Console.ReadLine());  //0 esetén hibát fog dobni.

            try
            {
                int eredmeny = 5 / oszto;
                Console.WriteLine($"Az eredmény: {eredmeny}");  // hiba esetén ez a sor már nem tud lefutni.
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nullaval nem tudunk osztani.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ismeretlen hiba történt.");
            }
            finally
            {
                Console.WriteLine("A finally blockban található utasítások mindenképp le fognak futni.");
            }
        }
    }
}
