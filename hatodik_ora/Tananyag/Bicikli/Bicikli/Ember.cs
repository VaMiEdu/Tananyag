using System;
using System.Collections.Generic;
using System.Text;

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

        public void ElindulABiciklivel(double sebesseg)
        {
            Bicikli.Gyorsit(sebesseg);
        }
    }
}
