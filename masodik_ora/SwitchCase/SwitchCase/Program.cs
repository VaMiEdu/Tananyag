using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch case

            char character = (char)Console.Read();

            switch (character)
            {
                case 'K':
                case 'k':
                    Console.WriteLine($"A választott betű: {character}");
                    Console.WriteLine("kávét kértél");
                    break;
                case 'T':
                case 't':
                    Console.WriteLine("teát kértél");
                    break;
                default:
                    Console.WriteLine("ismeretlen ital");
                    break;
            }
        }
    }
}
