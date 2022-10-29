using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary - k. - szótárak
            //key - value

            Dictionary<string, long> telefonKonyv = new Dictionary<string, long>();

            //kulcs-érték párok hozzáadása
            telefonKonyv.Add("Misi", 0665656566);
            telefonKonyv.Add("Mariska", 0611116566);
            telefonKonyv.Add("Pistike", 066511166);

            foreach (var item in telefonKonyv)
            {
                Console.WriteLine(item);
            }

            //elemek törlése
            telefonKonyv.Clear();

            // szerepele-e az adott kulcs a dictionary-ben
            bool szerepelE = telefonKonyv.ContainsKey("M");

            //szerepel-e az adott value a dictionary-ben
            telefonKonyv.ContainsValue(3434);

            //kulcs-érték pár deklarálása és inicializálása
            KeyValuePair<string, long> kulcsErtekPar = new KeyValuePair<string, long>();

            telefonKonyv.Contains(kulcsErtekPar);


            if (!telefonKonyv.ContainsKey("Misi"))
            {
                telefonKonyv.Add("Misi", 0665656566);
            }
            else
            {
                telefonKonyv["Misi"] = 0665656566;
            }

            try
            {
                telefonKonyv.Add("Misi", 0665656566);
            }

            catch (Exception)
            {
                Console.WriteLine("Létező kulcsu elemet nem lehetsz kétszer hozzáadni.");
            }


            var success = telefonKonyv.TryAdd("Nev", 565656);

            var success1 = telefonKonyv.TryGetValue("Nev", out long visszaKapottErtek);

            //KeyValuePair<string, long> kulcsErtekPar = new KeyValuePair<string, long>();

            var telefonKonyv1 = new Dictionary<string, ulong>();

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Add meg a nevet!");
                var bekertNev = Console.ReadLine();

                if (telefonKonyv1.ContainsKey(bekertNev))
                {
                    Console.WriteLine("Mát létező név.");
                }
                else
                {
                    Console.WriteLine("Add meg a számot!");
                    var bekertSzam = Convert.ToUInt64(Console.ReadLine());
                    telefonKonyv1.Add(bekertNev, bekertSzam);
                }
            }

            foreach (var entry in telefonKonyv1)
            {
                Console.WriteLine($"Név: {entry.Key} |  Telefonszám: {entry.Value}");
            }


            while (telefonKonyv1.Count <= 5)
            {
                Console.WriteLine("Add meg a nevet!");
                var bekertNev = Console.ReadLine();

                Console.WriteLine("Add meg a számot!");
                var bekertSzam = Convert.ToUInt64(Console.ReadLine());

                if (!telefonKonyv1.TryAdd(bekertNev, bekertSzam))
                {
                    Console.WriteLine("Létező nevet nem lehet mégegyszer hozzáadni.");
                }
            }
        }
    }
}
