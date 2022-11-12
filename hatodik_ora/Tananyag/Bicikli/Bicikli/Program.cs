using System;
using System.Collections.Generic;
using System.Linq;

namespace Bicikli
{
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
            //Bicikli bicikli = new Bicikli();
            Lampa elsoLampa = new Lampa();
            Lampa hatsooLampa = new Lampa();

            List<Kerek> bicoKerekek = new List<Kerek>() { new Kerek(), new Kerek() };

            Bicikli bicaj = new Bicikli(elsoLampa, hatsooLampa, bicoKerekek);
            Ember ember = new Ember(pumpa, bicaj);

            ember.ElindulABiciklivel(20);

            //ember.BicikliBeallitasa();

            //bicaj.Gyorsit(20);
            Motor motor = new Motor();

            Auto auto = new Auto(elsoLampa, hatsooLampa, bicoKerekek);

            auto.Motor = motor;

            auto.Motor.Megy = true;

        }
    }
}
