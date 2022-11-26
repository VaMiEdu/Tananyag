using System;

namespace Strategy
{
    //Strategy

    class KaveAutomata
    {
        //kávédaralas
        //vizforralas
        //cukorhazaadás, lefőzés
        //Beleönti a pohárba 

        public KaveAutomata(IDaralo daralo, IVizForralo vizforralo, IPoharKeszitoModul poharKeszitoModul )
        {
            Daralo = daralo;
            Vizforralo = vizforralo;
            PoharKeszitoModul = poharKeszitoModul;
        }

        public IDaralo Daralo { get; }
        public IVizForralo Vizforralo { get; }
        public IPoharKeszitoModul PoharKeszitoModul { get; }

        public void KavetKeszit()
        {
            Daralo.Daral();
            Vizforralo.VizetForral();
            PoharKeszitoModul.GetPohar();
        }
    }

    public interface IDaralo
    {
        void Daral();
    }

    public interface IVizForralo
    {
        void VizetForral();
    }


    public interface IPohar
    {
        void KavetTarol();
    }

    public interface IPoharKeszitoModul
    {
        IPohar GetPohar();
    }

    public class DragaPohar : IPohar
    {
        public void KavetTarol()
        {
            Console.WriteLine("Papír pohár, nem égeti a kezed.");
        }
    }
    public class OlcsoPohar : IPohar
    {
        public void KavetTarol()
        {
            Console.WriteLine("Muanyag pohár, égeti a kezed.");
        }
    }

    public class OlcsoPoharModul : IPoharKeszitoModul
    {
        public IPohar GetPohar()
        {
            return new OlcsoPohar();
        }
    }

    public class DragaPoharModul : IPoharKeszitoModul
    {
        public IPohar GetPohar()
        {
            return new DragaPohar();
        }
    }

    public class OlcsoVizForralo : IVizForralo
    {
        public void VizetForral()
        {
            Console.WriteLine($"Vizet forral {new Random().Next(60,80)} °C -ra.");
        }
    }

    public class DragaVizForralo : IVizForralo
    {
        public void VizetForral()
        {
            Console.WriteLine($"Vizet forral pontosan 72,9 °C -ra.");
        }
    }

    public class OlcsoDaralo : IDaralo
    {
        public void Daral()
        {
            Console.WriteLine("Kevés áramot vesz fel..");
            Console.WriteLine("Műanyagkéssel kávét darál..");
            Console.WriteLine("brbrtbrbbtrt..");
        }
    }

    public class DragaDaralo : IDaralo
    {
        public void Daral()
        {
            Console.WriteLine("Több áramot vesz fel..");
            Console.WriteLine("Kerámiakéssel kávét darál..");
            Console.WriteLine("PssPssPss..");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            var olcsoKaveAutomata = new KaveAutomata(new OlcsoDaralo(), new OlcsoVizForralo(), new OlcsoPoharModul());
            olcsoKaveAutomata.KavetKeszit();

            var dragaKaveAutomata = new KaveAutomata(new DragaDaralo(), new DragaVizForralo(), new DragaPoharModul());
            dragaKaveAutomata.KavetKeszit();

        }
    }
}
