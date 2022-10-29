using System;
using System.Collections.Generic;

namespace Jarmu
{
    public interface Jarmu
    {
        public bool KellEHozzaJogositvany { get; set; }
        public void Megy();
    }

    //abstract class Jarmu
    //{
    //    public bool KellEHozzaJogositvany { get; set; }

    //    public void Megy()
    //    {
    //        Console.WriteLine("Meegy a jármű...");
    //    }

    //    public override string ToString()
    //    {

    //        return $"Adatok: \n Kell hozzá jogsi? \n {KellEHozzaJogositvany}";
    //    }
    //}

    class SzarazfoldiJarmu : Jarmu
    {
        public int KerekekSzama { get; }
        public bool KellEHozzaJogositvany { get; set; }
        public SzarazfoldiJarmu(int kerekekSzama)
        {
            KerekekSzama = kerekekSzama;
        }

        public SzarazfoldiJarmu()
        {
            KerekekSzama = 4;
        }

        public void Megy()
        {
            Console.WriteLine("brumm brumm brummm...");
        }

        public override string ToString()
        {
            var jarmuToStringje = base.ToString();
            return $"{jarmuToStringje} \n Kerekek száma: \n {KerekekSzama} \n";
        }
    }

    class ViziJarmu : Jarmu
    {
        bool vitorlasE;
        public bool VitorlasE { get => vitorlasE; set => vitorlasE = value; }
        public bool KellEHozzaJogositvany { get; set; }

        public new void Megy()
        {
            Console.WriteLine("Psss pssss");
        }

        public override string ToString()
        {
            var jarmuToStringje = base.ToString();
            return $"{jarmuToStringje} Vitorlás? \n {VitorlasE} \n";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Jarmu valamilyenJarmu = new Jarmu();
            //valamilyenJarmu.KellEHozzaJogositvany = true;

            //Console.WriteLine(valamilyenJarmu.ToString());

            //SzarazfoldiJarmu trabant = new SzarazfoldiJarmu(4);
            //SzarazfoldiJarmu trabant = new SzarazfoldiJarmu();

            //trabant.KellEHozzaJogositvany = true;
            //kocsi.Megy();

            //lada.KellEHozzaJogositvany = false;

            //Console.WriteLine(trabant.ToString());

            //ViziJarmu csonak = new ViziJarmu();
            //csonak.KellEHozzaJogositvany = false;
            //csonak.VitorlasE = false;
            //csonak.Megy();
            //Console.WriteLine(csonak.ToString());

            SzarazfoldiJarmu trabant = new SzarazfoldiJarmu();
            SzarazfoldiJarmu bogarhatu = new SzarazfoldiJarmu();
            SzarazfoldiJarmu lada = new SzarazfoldiJarmu(4);

            List<SzarazfoldiJarmu> kocsik = new List<SzarazfoldiJarmu>();
            kocsik.Add(trabant);
            kocsik.Add(bogarhatu);
            kocsik.Add(lada);

            foreach (var kocsi in kocsik)
            {
                Console.WriteLine(kocsi);
            }

            //            public int KerekekSzama { get; }
            //public bool KellEHozzaJogositvany { get; set; }

            int kerekekSzama = Convert.ToInt32(Console.ReadLine());
            bool kellEHozzaJogsi = Convert.ToBoolean(Console.ReadLine());

            SzarazfoldiJarmu sajatKocsi = new SzarazfoldiJarmu(kerekekSzama);
            sajatKocsi.KellEHozzaJogositvany = kellEHozzaJogsi;

            ViziJarmu csonak = new ViziJarmu();
            csonak.KellEHozzaJogositvany = false;

            List<Jarmu> mindenFeleJarmu = new List<Jarmu>();

            mindenFeleJarmu.Add(sajatKocsi);
            mindenFeleJarmu.Add(csonak);
        }
    }
}
