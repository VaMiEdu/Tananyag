using System;
using System.Collections.Generic;

namespace Osztalyok
{
    enum Szinek { Fekete, Feher, Voros, Barna, Tarka }
    class EmlosAllat
    {
        const bool ElevenSzulo = true;

        Szinek szin;
        int kipihentseg = 100;

        //int Magassag { get; set; }

        private int magassag;

        public int Magassag
        {
            get { return magassag; }
            set
            {
                if (value <= 50)
                {
                    magassag = value;
                }
            }
        }


        public void Taplalkozik()
        {
            Console.WriteLine("Az állat éppen eszik és iszik.");
        }

        public void Alszik()
        {
            Console.WriteLine("Az állat éppen alszik.");
        }

        public override string ToString()
        {
            var kiiratandoSzoveg = $"Színe: {szin}, magassága: {magassag}, kipihentsége: {kipihentseg}";
            return kiiratandoSzoveg;
        }
    }

    class Kutya : EmlosAllat
    {
        //bool husegesE = true;

        public bool HusegesE { get; set; }

        public void FarokCsovalasa()
        {
            Console.WriteLine("--Farokcsovalas in progress--");
        }
    }

    class Macska
    {
        bool dorombol;

        public void Dagaszt()
        {

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            EmlosAllat egyEmlosAllat = new EmlosAllat();

            egyEmlosAllat.Magassag = 10;

            var allatMagassaga = egyEmlosAllat.Magassag;

            egyEmlosAllat.Alszik();

            Kutya panka = new Kutya();

            panka.Magassag = 1;

            Console.WriteLine($"Panka magassága: {panka.Magassag}");

            panka.Taplalkozik();
        }
    }
}
