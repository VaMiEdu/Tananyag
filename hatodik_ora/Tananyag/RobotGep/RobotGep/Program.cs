using System;
using System.Collections.Generic;

namespace RobotGep
{
    class RobotGep
    {
        protected bool MukodikE;

        public void Leallit()
        {
            MukodikE = false;
        }

        public virtual void Mukodik()
        {
            Console.WriteLine("Megy a robotgép!");
            MukodikE = true;
        }
    }

    class TurmixGep : RobotGep
    {
        public new void Mukodik()
        {
            MukodikE = true;

            Console.WriteLine("Megy a turmixgép!");
        }
    }

    class KaveDaralo : RobotGep
    {
        public new void Mukodik()
        {
            MukodikE = true;

            Console.WriteLine("Megy a kavédaráló!");
        }
    }

    class Huto
    {
        public List<IElelmiszer> Elelmiszerek { get; set; }
    }

    interface IElelmiszer
    {
        DateTime LejaratiIdo { get; set; }
        bool FogyaszthatoE { get; }
        int Mennyiseg { get; set; }
    }

    class Kave : IElelmiszer
    {
        public DateTime LejaratiIdo { get; set; }

        private bool fogyaszthatoE;

        public bool FogyaszthatoE
        {
            get 
            {
                //TODO implement logic;
                return fogyaszthatoE; 
            }
        }

        public int Mennyiseg { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Gyumolcs : IElelmiszer
    {
        public DateTime LejaratiIdo { get; set; }

        private bool fogyaszthatoE;

        public bool FogyaszthatoE
        {
            get
            {
                //TODO implement logic;
                return fogyaszthatoE;
            }
        }

        public int Mennyiseg { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            RobotGep robotGep = new RobotGep();
            TurmixGep turmixGep = new TurmixGep();
            KaveDaralo kvDaralo = new KaveDaralo();

            robotGep.Mukodik();
            turmixGep.Mukodik();
            kvDaralo.Mukodik();
        }
    }
}
