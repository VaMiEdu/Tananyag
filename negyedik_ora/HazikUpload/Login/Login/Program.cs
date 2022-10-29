using System;
using System.Collections.Generic;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Írjatok egy programot, ami felismeri az adott usereket:

            //            username password
            //admin @Dm1N
            //kate flower
            //john hacker

            //A konzolról várjuk egy felhasználónevet, majd a jelszót.
            //Ha helyes felhasználónevet & jelszót adunk meg, írjuk ki: "You have successfully logged in!"
            //Helytelen felhasználó vagy jelszó esetében: "Incorrect username or password!"

            Dictionary<string, string> database;

            database = GenerateUsersAndPasswords();

            if (Login(database))
            {
                Console.WriteLine("You have successfully logged in!");
            }
            else
            {
                Console.WriteLine("Incorrect username or password!");
            }
        }

        private static bool Login(Dictionary<string, string> database)
        {
            string userName = string.Empty;
            string password = string.Empty;

            Console.WriteLine("Username:");
            userName = Console.ReadLine();


            Console.WriteLine("Password:");
            password = Console.ReadLine();
            
            if (database.TryGetValue(userName, out string realPassword))
            {
                if (password == realPassword)
                {
                    return true;
                }
            }

            return false;
        }

        private static Dictionary<string, string> GenerateUsersAndPasswords()
        {
            Dictionary<string, string> users = new Dictionary<string, string>()
            {
                { "admin", "@Dm1N" },
                { "kate", "flower" },
                { "john", "hacker" },
            };

            return users;
        }
    }
}
