using System;
using System.Collections.Generic;

namespace RobotGep
{
    internal class Program
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

            public void Turmixol(List<Gyumolcs> gyumolcsok)
            {
                foreach (var gyumolcs in gyumolcsok)
                {
                    if (gyumolcs.Mennyiseg > 1)
                    {
                        gyumolcs.Mennyiseg -= 1;
                    }
                }
            }
        }

        class KaveDaralo : RobotGep
        {
            public new void Mukodik()
            {
                MukodikE = true;

                Console.WriteLine("Megy a kavédaráló!");
            }

            public void KavetDaral(Kave kave)
            {
                if (kave.Mennyiseg < 1)
                {
                    return;
                }

                kave.Mennyiseg -= 1;
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
}
