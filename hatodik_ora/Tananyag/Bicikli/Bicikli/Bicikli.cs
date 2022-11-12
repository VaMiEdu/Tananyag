using System;
using System.Collections.Generic;
using System.Text;

namespace Bicikli
{
    class Pedal
    {

    }

    class Bicikli : Jarmu
    {
        public Bicikli(Lampa elsoLampa, Lampa hatsoLampa, List<Kerek> kerekek) : base(elsoLampa, hatsoLampa, kerekek)
        {
        }

        public Pedal Pedal { get; set; }

        public new void Gyorsit(double mennyiseg)
        {
            if (mennyiseg + Sebesseg <= 40)
            {
                base.Gyorsit(mennyiseg);
            }
        }
    }
}
