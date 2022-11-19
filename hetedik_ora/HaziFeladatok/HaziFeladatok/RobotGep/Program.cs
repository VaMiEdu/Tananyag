using System;
using System.Collections.Generic;

namespace RobotGep1
{

    interface IRobotGep<T>
    {
        void Leallit();
        void Mukodik(T elelmiszer);
    }

    //class RobotGep
    //{
    //    protected bool MukodikE;

    //    public void Leallit()
    //    {
    //        MukodikE = false;
    //    }

    //    public virtual void Mukodik()
    //    {
    //        Console.WriteLine("Megy a robotgép!");
    //        MukodikE = true;
    //    }
    //}

    class TurmixGep<T> : IRobotGep<IElelmiszer>
    {
        protected bool MukodikE;

        public new void Mukodik(IElelmiszer gyumolcs)
        {
            MukodikE = true;

            Console.WriteLine("Megy a turmixgép!");
            //foreach (var gyumolcs in gyumolcsok)
            //{
            //    if (gyumolcs.Mennyiseg > 1)
            //    {
            //        gyumolcs.Mennyiseg -= 1;
            //    }
            //}

            if (gyumolcs.Mennyiseg > 1)
            {
                gyumolcs.Mennyiseg -= 1;
            }
        }

        public void Leallit()
        {

        }

        //public void Turmixol(List<Gyumolcs> gyumolcsok)
        //{
        //    foreach (var gyumolcs in gyumolcsok)
        //    {
        //        if (gyumolcs.Mennyiseg > 1)
        //        {
        //            gyumolcs.Mennyiseg -= 1;
        //        }
        //    }
        //}
    }

    class KaveDaralo<T> : IRobotGep<IElelmiszer>
    {
        protected bool MukodikE;

        public new void Mukodik(IElelmiszer kave)
        {
            MukodikE = true;

            Console.WriteLine("Megy a kavédaráló!");
            if (kave.Mennyiseg < 1)
            {
                return;
            }

            kave.Mennyiseg -= 1;
        }

        //public void KavetDaral(Kave kave)
        //{
        //    if (kave.Mennyiseg < 1)
        //    {
        //        return;
        //    }

        //    kave.Mennyiseg -= 1;
        //}

        public void Leallit()
        {

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

        private int mennyiseg;

        public bool FogyaszthatoE
        {
            get
            {
                return DateTime.Now < LejaratiIdo;
            }
        }

        public int Mennyiseg
        {
            get
            {
                return mennyiseg;
            }

            set
            {
                if (value > 0)
                {
                    mennyiseg = value;
                }
            }
        }

        public Kave(DateTime lejaratiIdo, int mennyiseg)
        {
            LejaratiIdo = lejaratiIdo;
            Mennyiseg = mennyiseg;
        }


    }

    class Gyumolcs : IElelmiszer
    {
        private int mennyiseg;

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

        public Gyumolcs(DateTime lejaratiIdo, int mennyiseg)
        {
            LejaratiIdo = lejaratiIdo;
            Mennyiseg = mennyiseg;
        }
        public int Mennyiseg
        {
            get
            {
                return mennyiseg;
            }

            set
            {
                if (value > 0)
                {
                    mennyiseg = value;
                }
            }
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //RobotGep robotGep = new RobotGep();

            TurmixGep<Gyumolcs> turmixGep = new TurmixGep<Gyumolcs>();
            KaveDaralo<Kave> kvDaralo = new KaveDaralo<Kave>();

            //robotGep.Mukodik();

            var gyumolcs = new Gyumolcs(new DateTime(2023, 01, 01), 10);
            var kave = new Kave(new DateTime(2023, 01, 01), 10);

            List<IElelmiszer> elelmiszerek = new List<IElelmiszer>();
            elelmiszerek.Add(gyumolcs);
            elelmiszerek.Add(kave);

            turmixGep.Mukodik(gyumolcs);
            kvDaralo.Mukodik(kave);
        }
    }
}

