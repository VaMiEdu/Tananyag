using System;
using System.Collections.Generic;
using System.Text;

namespace Bicikli
{
    class Motor
    {
        public bool Megy { get; set; }
    }


    class Auto : Jarmu
    {
        public Auto(Lampa elsoLampa, Lampa hatsoLampa, List<Kerek> kerekek) : base(elsoLampa, hatsoLampa, kerekek)
        {
        }

        public Motor Motor { get; set; }


        public new void Gyorsit(double mennyiseg)
        {
            if (mennyiseg + Sebesseg <= 120)
            {
                base.Gyorsit(mennyiseg);
            }
        }
    }
}
