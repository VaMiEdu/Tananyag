using System;

namespace Alkalmazott
{

    //    - Hozzunk létre egy Alkalmazott abstract class-t melynek legyen Nev, Eletkor property-je.
    //- Hozzuk létre a FixAlkalmazott és Contractor class-okat, melyek az Alkalmazottt class-ból származzanak.

    //- A FixAlkalmazott class-nak legyen egy Fizetes full property-je, melynek értékét a constructoron keresztül állítsuk be.
    //- A

    //Contractor   class-nak legyen továbbá egy Oraber full property-je, melynek értékét a constructoron keresztül állítsuk be.
    //- Overrideoljuk a származtatott classokban a ToString() metódust, melyen keresztül írassuk ki a class adatait. (név, életkor, fizetés)

    abstract class Alkalmazott
    {
        public string Nev { get; set; }
        public int Eletkor { get; set; }

        public override string ToString()
        {
            return $"Név: {Nev} \n Életkor: {Eletkor} \n".ToString();
        }
    }

    class FixAlkalmazott : Alkalmazott
    {
        private int fizetes;

        public int Fizetes
        {
            get { return fizetes; }
            set { fizetes = value; }
        }

        public FixAlkalmazott(int fizetes)
        {
            this.fizetes = fizetes;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Fizetés: {Fizetes} \n " ;
        }
    }

    class Contractor : Alkalmazott
    {
        private int oraber;

        public int Oraber
        {
            get { return oraber; }
            set { oraber = value; }
        }

        public Contractor(int oraber)
        {
            Oraber = oraber;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Órabér: {Oraber} \n ";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
