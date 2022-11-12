using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bicikli
{
    class Kerek
    {
        public double Nyomas { get; set; }
    }

    class Lampa
    {
        public bool Mukodik { get; set; }
    }

    class Jarmu
    {
        private bool megyE;

        public List<Kerek> Kerekek = new List<Kerek>();
        public Lampa ElsoLampa { get; set; }
        public Lampa HatsoLampa { get; set; }

        public double Sebesseg { get; set; }

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
}
