using System;

namespace Generikusok
{
    class Ellenorzes<T>
    {
        //public bool Egyenloek(int elso, int masodik)
        //{
        //    return elso == masodik;
        //}

        //public bool Egyenloek(double elso, double masodik)
        //{
        //    return elso == masodik;
        //}

        //public bool Egyenloek(string elso, string masodik)
        //{
        //    return elso == masodik;
        //}

        public bool Egyenloek<T>(T elso, T masodik)
        {
            return elso.Equals(masodik);
            //return elso == masodik;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ellenorzes<int> ellenorzes = new Ellenorzes<int>();

            //ellenorzes.Egyenloek(3, 4);

            ellenorzes.Egyenloek<int>(3, 4);

            Ellenorzes<string> stringEllenorzes = new Ellenorzes<string>();
            stringEllenorzes.Egyenloek<string>("elso", "masodik");
        }
    }
}
