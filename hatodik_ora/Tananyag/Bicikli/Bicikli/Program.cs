using System;
using System.Collections.Generic;
using System.Linq;

namespace Bicikli
{
    class Ember
    {
        public Pumpa Pumpa { get; set; }
        public Bicikli Bicikli { get; set; }
        //public Lampa ElsoLampa { get; set; }
        //public Lampa HatsoLampa { get; set; }
        //public List<Kerek> Kerekek { get; set; }

        public Ember(Pumpa pumpa, Bicikli bicikli)
        {
            Pumpa = pumpa;
            Bicikli = bicikli;
        }

        public void BicikliBeallitasa()
        {
            Bicikli.ElsoLampa.Mukodik = true;
            Bicikli.HatsoLampa.Mukodik = true;

            Pumpa.Felfuj(Bicikli.Kerekek, 6);
        }
    }

    class Jarmu
    {
        private bool megyE;
        private double sebesseg;

        public List<Kerek> Kerekek = new List<Kerek>();

        public Lampa ElsoLampa { get; set; }
        public Lampa HatsoLampa { get; set; }

        public double Sebesseg { get => sebesseg; set => sebesseg = value; }

        public Jarmu(Lampa elsoLampa, Lampa hatsoLampa, List<Kerek> kerekek)
        {
            ElsoLampa = elsoLampa;
            HatsoLampa = hatsoLampa;
            Kerekek = kerekek;
        }

        public void Lassit(double mennyiseg)
        {
            if (megyE)
            {
                if (mennyiseg > Sebesseg)
                {
                    Sebesseg = 0;
                    megyE = false;
                }
                else
                {
                    Sebesseg -= mennyiseg;
                }
            }

        }

        public void Gyorsit(double mennyiseg)
        {
            if (KerekekNyomasaOk() && LampakMukodnekE())
            {
                Sebesseg += mennyiseg;
                megyE = true;
            }
        }

        private bool KerekekNyomasaOk()
        {
            //bool vanEOlyanKerekAminekKisebbANyomasaMint6Bar = false;

            //foreach (var kerek in Kerekek)
            //{
            //    if (kerek.Nyomas < 6)
            //    {
            //        vanEOlyanKerekAminekKisebbANyomasaMint6Bar = true;
            //    }
            //}

            //return vanEOlyanKerekAminekKisebbANyomasaMint6Bar;

            return Kerekek.All(x => x.Nyomas >= 6);
        }

        public bool LampakMukodnekE()
        {
            var elsoLampaMukodik = ElsoLampa.Mukodik;
            var hatsoLampaMukodik = HatsoLampa.Mukodik;

            return elsoLampaMukodik && hatsoLampaMukodik;
        }
    }

    class Auto : Jarmu
    {
        public Motor Motor { get; set; }

        public Auto()
        {
        }

        public new void Gyorsit(double mennyiseg)
        {
            if (mennyiseg + Sebesseg <= 120)
            {
                base.Gyorsit(mennyiseg);
            }
        }
    }

    class Bicikli : Jarmu
    {
        public Pedal Pedal { get; set; }

        public new void Gyorsit(double mennyiseg)
        {
            if (mennyiseg + Sebesseg <= 40)
            {
                base.Gyorsit(mennyiseg);
            }
        }
    }


    class Kerek
    {
        public double Nyomas { get; set; }
    }

    class Lampa
    {
        public bool Mukodik { get; set; }
    }

    class Pedal
    {

    }

    class Motor
    {

    }

    class Pumpa
    {
        public void Felfuj(Kerek kerek)
        {
            kerek.Nyomas += 1;
        }

        public void Felfuj(List<Kerek> kerekek, double idealisNyomas)
        {
            foreach (var kerek in kerekek)
            {
                if (kerek.Nyomas < idealisNyomas)
                {
                    kerek.Nyomas = idealisNyomas;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Auto kocsi = new Auto();

            //Lampa elsoLampa = new Lampa();
            //Lampa hatsoLampa = new Lampa();

            //elsoLampa.Mukodik = true;
            //hatsoLampa.Mukodik = true;

            //Kerek kerek1 = new Kerek();
            //Kerek kerek2 = new Kerek();
            //Kerek kerek3 = new Kerek();
            //Kerek kerek4 = new Kerek();

            //List<Kerek> kerekek = new List<Kerek>()
            //{
            //    kerek1, kerek2, kerek3, kerek4
            //};

            //Pumpa pumpa = new Pumpa();
            //pumpa.Felfuj(kerek1);

            //pumpa.Felfuj(kerekek, 6);

            //kerek1.Nyomas = 8;
            //kerek2.Nyomas = 8;
            //kerek3.Nyomas = 8;
            //kerek4.Nyomas = 8;

            //kocsi.HatsoLampa = hatsoLampa;
            //kocsi.ElsoLampa = elsoLampa;
            //kocsi.Kerekek.Add(kerek1);
            //kocsi.Kerekek.Add(kerek2);
            //kocsi.Kerekek.Add(kerek3);
            //kocsi.Kerekek.Add(kerek4);

            //kocsi.Gyorsit(10.0);
            //-----------------------------------------------------------------

            Pumpa pumpa = new Pumpa();
            Bicikli bicikli = new Bicikli();
            Lampa elsoLampa = new Lampa();
            Lampa hatsooLampa = new Lampa();

            List<Kerek> bicoKerekek = new List<Kerek>() { new Kerek(), new Kerek() };

            Ember ember = new Ember(pumpa, bicikli, elsoLampa, hatsooLampa, bicoKerekek);

            ember.BicikliBeallitasa();
        }
    }
}
