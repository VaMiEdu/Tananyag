using System;
using System.Collections.Generic;
using System.Linq;

namespace UtazasNyilvantarto
{
    class Utazo
    {

        public string Nev { get; set; }
        public Dictionary<DateTime, string> Allomasok { get; set; }

        private int latogatottHelyekSzama;

        public int MyProperty
        {
            get { return latogatottHelyekSzama; }
            set { latogatottHelyekSzama = value; }
        }



        public Utazo(string nev)
        {
            //if (string.IsNullOrWhiteSpace(nev))
            //{
            //    throw new ArgumentException($"A megadott név ({nev}) nem megfelelő formátumú!");
            //}

            Nev = nev;
        }

        public void Utazik(DateTime idoPont, string helyNeve)
        {
            Allomasok.TryAdd(idoPont, helyNeve);

            latogatottHelyekSzama = Allomasok.Count;
        }

        public bool JartE(string helyNeve)
        {
            return Allomasok.Any(x => x.Value.Equals(helyNeve));
        }

        public int HanyHelyenJart() => latogatottHelyekSzama;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
