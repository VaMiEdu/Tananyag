using System;

namespace Bicikli
{
    class Bicikli
    {
        private bool megy;

        public Lampa ElsoLampa { get; set; }
        public Lampa HatsoLampa { get; set; }

        private Pedal pedal = new Pedal();

        public Pedal Pedal
        {
            get 
            {
                return pedal; 
            }
            set 
            {
                pedal = value;
            }
        }

        public void Elindul()
        {
            Pedal.HajtvaVan = true;
            megy = true;
        }


    }

    class Lampa
    {

    }

    class Pedal
    {
        public bool HajtvaVan { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bicikli b = new Bicikli();

            b.Pedal.HajtvaVan = true;

            b.Elindul();
            Console.WriteLine("Hello World!");
        }
    }
}
