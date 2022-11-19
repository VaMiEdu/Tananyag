using System;
using System.Collections.Generic;
using System.IO;

namespace Telekocsi
{
    class Auto
    {
        public string Indulas { get; set; }
        public string Cel { get; set; }
        public string Rendszam { get; set; }
        public string Telefonszam { get; set; }
        public int Ferohely { get; set; }

        public override string ToString()
        {
            return $"Indulás: {Indulas} \n Cél: {Cel} \n Rendszam: {Rendszam} \n Telszam: {Telefonszam} \n Ferőhelyek száma: {Ferohely}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autok = new List<Auto>();

            using (StreamReader reader = new StreamReader(@"autok.csv"))
            {
                _ = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var sor = reader.ReadLine();
                    var splitted = sor.Split(';');

                    var auto = new Auto()
                    {
                        Indulas = splitted[0],
                        Cel = splitted[1],
                        Rendszam = splitted[2],
                        Telefonszam = splitted[3],
                        Ferohely = Convert.ToInt16(splitted[4]),
                    };

                    autok.Add(auto);
                }
            }

            foreach (var auto in autok)
            {
                Console.WriteLine(auto.ToString());
            }
        }
    }
}
