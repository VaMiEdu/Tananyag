using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Ember
    {
        public string Nev { get; set; }
        public int Eletkor { get; set; }
    }

    class Kutya
    {
        public string Nev { get; set; }
        public int Eletkor { get; set; }
        public string Gazdi { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ
            //language integrated query 
            //expression tree - kifejezésfa

            List<int> numbers = new List<int>() { 1, 3, 7, 4, 5, 10, 40, 20 };
            List<string> dogBreeds = new List<string>();

            dogBreeds.Add("Bulldog");
            dogBreeds.Add("German Shepherd");
            dogBreeds.Add("Poodle");
            dogBreeds.Add("Chihuahua");
            dogBreeds.Add("Border Collie");
            dogBreeds.Add("Siberian Husky");


            var dogSpaces = from dog in dogBreeds where dog.Contains(" ") select dog;


            var greaterThan5 = from number in numbers
                               where number > 5
                               select number;

            var novekvoLegyenASorrent = true;

            if (novekvoLegyenASorrent)
            {
                var x = from newNumbers in greaterThan5
                        orderby newNumbers ascending
                        select newNumbers;
            }

            else
            {
                var x = from newNumbers in greaterThan5
                        orderby newNumbers descending
                        select newNumbers;
            }

            var numbersAsList = greaterThan5.ToList();

            List<int> greaterThan10 = numbers.Where(n => n > 10).OrderBy(n => n).ToList();
            bool mindegyikSzamNagyobbMintNulla = numbers.All(n => n > 0);
            bool vanEOlyanSzamAmelyikNagyobbMint5 = numbers.Any(n => n > 5);

            int[] numbersAsArray = greaterThan5.ToArray();

            var pudli = from dog in dogBreeds
                        where dog.Equals("Poodle") || dog.Equals("Chihuahua")
                        select dog;


            List<Kutya> kutyak = new List<Kutya>()
            {
                new Kutya(){ Nev="Panka", Eletkor = 1, Gazdi = "Misi" },
                new Kutya(){ Nev="Dugó", Eletkor = 13, Gazdi = "Misi" },
                new Kutya() { Nev="Büdös", Eletkor = 6, Gazdi = "Roland" },
                new Kutya() {Nev="Füles", Eletkor = 3, Gazdi = "Viki" },
                new Kutya() {Nev="Bolhás", Eletkor = 10, Gazdi = "Fanni" },
            };

            List<Ember> gazdik = new List<Ember>()
            {
                new Ember(){ Nev = "Misi", Eletkor = 31 },
                new Ember(){ Nev = "Roland", Eletkor = 30 },
                new Ember(){ Nev = "Viki", Eletkor = 29 },
                new Ember(){ Nev = "Fanni", Eletkor = 28 },
            };

            //join
            var gazdikEsKutyusok = from kutya in kutyak
                                   join gazdi in gazdik
                                   on kutya.Gazdi equals gazdi.Nev

                                   select new
                                   {
                                       GazdiNeve = gazdi.Nev,
                                       GazdiKora = gazdi.Eletkor,
                                       KutyusNeve = kutya.Nev
                                   };

            var gazdikEsKutyusokAsGroup = from gazdiKutyus in gazdikEsKutyusok
                                          group new
                                          {
                                              gazdiKutyus.KutyusNeve
                                          } by gazdiKutyus.GazdiNeve into newGroup
                                          select newGroup;
        }
    }
}
