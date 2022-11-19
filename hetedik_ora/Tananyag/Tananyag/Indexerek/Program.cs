
using System;
using System.Collections.Generic;

namespace Indexerek
{
    public class Ember
    {
        private Ember[] emberek;

        public Ember this[int index]
        {
            get { return emberek[index]; }
            set { emberek[index] = value; }
        }

        public string Nev { get; set; }
        public int Eletkor { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Ember> emberek = new List<Ember>();

            //emberek.Add(new Ember());
            //emberek.Add(new Ember());
            //emberek.Add(new Ember());
            //emberek.Add(new Ember());
            
            Ember[] emberek = new Ember[10];

            emberek[0] = new Ember() { Eletkor = 20, Nev = "Misi" };
            emberek[1] = new Ember() { Eletkor = 22, Nev = "Zsu" };

            for (int i = 0; i < emberek.Length; i++)
            {
                Console.WriteLine(emberek[i].Nev);
            }
        }
    }
}
