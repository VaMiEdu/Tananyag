using System;
using System.Collections.Generic;

namespace HaziFeladatok
{
    #region Teglalap class definition
    //    Készítsetek egy téglalap osztályt egy téglalap reprezentálására.
    //Rendelkezzen szélesség és magasság adatagokkal, ezek véletlenszámként jöjjenek létre a konstruktorban példányosításkor. (1-100 között)

    //Rendelkezzen egy NegyzetE metódussal, mely bool-ként visszaadja, hogy az adott téglalap négyzet-e is egyben.


    //Overrideoljátok a ToString() metódust, melyen keresztül vissza adjátok a téglalap paramétereit az alábbi formában.

    //A téglalap szélessége: 
    //A téglalap magassága:
    //Ez a téglalap nem négyzet. / Ez a téglalap egyben négyzet is.


    //Hozzatok létre a Main()-ben egy 10 elemű Téglalap típusú listát (az ehhez szükséges téglalap objektumokat egy for ciklusban inicializáljátok).

    //A Main()-ben egy foreach cikluson keresztül iteráljatok végig a listán és hívjátok meg a ToString() metódust az objektumokon és írjátok ki a konzolra a kapott információt.

    class Teglalap
    {
        private double szelesseg;
        private double magassag;

        public double Szelesseg { get => szelesseg; set => szelesseg = value; }
        public double Magassag { get => magassag; set => magassag = value; }

        public Teglalap()
        {
            Random r = new Random();
            szelesseg = r.NextDouble() * 100;
            magassag = r.NextDouble() * 100;
        }

        public bool NegyzetE() => szelesseg == magassag;

        public override string ToString()
        {
            if (NegyzetE())
            {
                return $"A téglalap szélessége: {szelesseg}, A téglalap magassága: {magassag}. Ez a téglalap egyben négyzet is egyben.";
            }
            else
            {
                return $"A téglalap szélessége: {szelesseg}, A téglalap magassága: {magassag}. Ez a téglalap nem négyzet.";
            }
        }
    }
    #endregion


    #region Haromszog class definition
    //    Készítsetek Háromszög osztályt, amely egy
    //háromszöghöz tárolja a három oldal hosszúságát! Legyen képes kerület, terület
    //számítására.
    //A terület számításához használhatjátok a Hérón képletet:


    //double s = Kerulet() / 2;
    //    terület =  Math.Sqrt(s* (s - a) * (s - b) * (s -
    //c));

    //Az a, b, c cáltozók a háromszög oldalai lesznek.
    class Haromszog
    {
        private double a;
        private double b;
        private double c;

        public double GetA()
        {
            return a;
        }

        public void SetA(double value)
        {
            if (value > 0)
            {
                a = value;
            }
        }

        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public double Kerulet()
        {
            return a + b + c;
        }

        public double Terulet()
        {
            if (a > 0 && b > 0 && c > 0)
            {
                double s = Kerulet() / 2;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            }
            //TODO throw argument exception
            return -1;
        }
    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            var haromSzog = new Haromszog();

            var kerulet = haromSzog.Kerulet();
            var terulet = haromSzog.Terulet();

            List<Teglalap> teglalapok = new List<Teglalap>();

            for (int i = 0; i < 10; i++)
            {
                Teglalap teglalap = new Teglalap();
                teglalapok.Add(teglalap);
            }

            foreach (var teglalap in teglalapok)
            {
                Console.WriteLine(teglalap.ToString());
            }
        }
    }
}
