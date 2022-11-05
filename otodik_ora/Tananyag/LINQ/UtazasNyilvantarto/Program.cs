using System;
using System.Collections.Generic;
using System.Linq;

namespace UtazasNyilvantarto
{
    class Utazo
    {
        public string Nev { get; set; }
        public Dictionary<DateTime, string> Allomasok { get; set; } = new Dictionary<DateTime, string>();

        private int latogatottHelyekSzama;

        public int LatogatottHelyekSzama
        {
            get
            {
                return latogatottHelyekSzama;
            }
        }

        public Utazo(string nev)
        {
            //Allomasok = new Dictionary<DateTime, string>();

            if (string.IsNullOrWhiteSpace(nev))
            {
                throw new ArgumentException($"A megadott név ({nev}) nem megfelelő formátumú!");
            }

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

        public string HolVoltElobb(string egyik, string masik)
        {
            var egyikHely = Allomasok.First(x => x.Value == egyik);
            var masikHely = Allomasok.First(x => x.Value == masik);

            if (egyikHely.Key < masikHely.Key)
            {
                return egyikHely.Value;
            }

            return masikHely.Value;

            //return egyikHely.Key < masikHely.Key ? egyikHely.Value : masikHely.Value;  // conditional operator vagy ternary operator

            //Készítsen metódust, amely megadja azokat a helyeket, ahol az utazó többször is járt!
            //string[] HelyekAholTobbszorJart()

        }

        public List<string> HelyekAholTobbszorJart()
        {
            return Allomasok.GroupBy(x => x.Value).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Utazo utazo = new Utazo("Misi");

            utazo.Utazik(new DateTime(2022, 02, 01), "Blahamák");
            utazo.Utazik(new DateTime(2019, 02, 01), "Hawaii");
            utazo.Utazik(new DateTime(2000, 02, 01), "Járda szigetek");
            utazo.Utazik(new DateTime(2000, 12, 01), "Járda szigetek");

            Console.WriteLine(utazo.JartE("Hawaii"));

            Console.WriteLine(utazo.HolVoltElobb("Blahamák", "Járda szigetek"));

            var helyekAholTobbszorJart = utazo.HelyekAholTobbszorJart();

            foreach (var hely in helyekAholTobbszorJart)
            {
                Console.WriteLine(hely);
            }

        }
    }
}
