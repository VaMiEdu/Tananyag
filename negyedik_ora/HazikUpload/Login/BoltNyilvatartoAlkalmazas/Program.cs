using System;
using System.Collections.Generic;
using System.Reflection;

namespace BoltNyilvatartoAlkalmazas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Készítsétek egy bolt nyilvátartó alkalmazást.

            //Kérjetek be 5 különböző terméket a billentyűzetről.
            //Ezután az 5 különböző terméknek generáljatok ki 1 és 20 között darabszámot(ennyi termék lesz készleten).

            //Ha a felhasználó beírja az adott termék nevét, majd egy enter után a darabszámot, annyival csökkentsétek a készlet mennyiségét./Ha a felhasználó 
            //Minden változás után írassátok ki az aktuális összes készletet.

            //Ha nem létező terméket próbál vásárolni, írjuk ki: "Unknown product".
            //Ha több darabot próbál vásárolni, mint ahány darab van készleten, írjuk ki: "Purchase not possible, not enough stock available from the given product."

            //Sikeres vásárlás esetén:
            //            "Sikeresen vásároltál a {vásárolandó termék neve} termékből {megvásárolni kívánt mennyiség} darabot."

            //Exit szóra kilépünk a programból.


            var stocks = FillupStocks();

            StartStockManager(stocks);

        }


        private static Dictionary<string, int> FillupStocks()
        {
            var stocks = new Dictionary<string, int>();
            var random = new Random();

            while (stocks.Count < 5)
            {
                Console.WriteLine("Adja meg a termék nevét:");

                var product = Console.ReadLine();

                if (stocks.ContainsKey(product))
                {
                    Console.WriteLine("Ez a termék már szerepel a listában. \n Adjon meg egy másik terméket.");
                }
                else
                {
                    var quantity = random.Next(1, 21);
                    stocks.Add(product, quantity);
                }

            }
            ShowCurrentStock(stocks);

            return stocks;
        }

        private static void ShowCurrentStock(Dictionary<string, int> stocks)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Aktuális készlet: ");

            foreach (var currentStock in stocks)
            {
                Console.WriteLine($"Termék neve: {currentStock.Key}   |   Elérhető darabszám: {currentStock.Value}");
            }

            Console.WriteLine("------------------------");
        }
        private static void StartStockManager(Dictionary<string, int> stocks)
        {
            var exitCondition = "exit";

            while (true)
            {
                Console.WriteLine("Add meg a vásárolni kívánt termék nevét:");

                var productToBuy = Console.ReadLine().ToLower();

                if (productToBuy.Equals(exitCondition))
                {
                    return;
                }

                Console.WriteLine("Add meg a vásárolni kívánt termék mennyiségét:");

                var quantityAsText = Console.ReadLine(); // .ToLower()

                if (quantityAsText.Equals(exitCondition))
                {
                    return;
                }

                var quantity = Convert.ToInt32(quantityAsText);

                if (!stocks.TryGetValue(productToBuy, out int currentQuantity))
                {
                    Console.WriteLine("Unknown product");
                }
                else
                {
                    if (currentQuantity <= quantity)
                    {
                        Console.WriteLine("Purchase not possible, not enough stock available from the given product.");
                        Console.WriteLine($"{currentQuantity} available");
                    }
                    else
                    {
                        stocks[productToBuy] = currentQuantity - quantity;
                        Console.WriteLine("Succesful purchase");

                        ShowCurrentStock(stocks);
                    }
                }
            }
        }
    }
}
