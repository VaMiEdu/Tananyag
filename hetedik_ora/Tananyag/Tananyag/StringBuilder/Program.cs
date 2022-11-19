using System;
using System.IO;
using System.Linq;
using System.Text;

namespace StringBuilder1
{
    class Vizsga
    {
        public string VizsgaKod { get; set; }
        public short PontSzam { get; set; }

        private Random random = new Random();

        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private short RandomPontszam(short hossz)
        {
            return (short)random.Next(0, hossz);
        }

        public Vizsga()
        {
            VizsgaKod = RandomString(6);
            PontSzam = RandomPontszam(100);
        }
    }

    class FileMuveletek
    {
        public void WriteToFile(string path, string content)
        {
            using StreamWriter writer = new StreamWriter(path);

            for (int i = 0; i < content.Length; i++)
            {
                writer.Write(content[i]);
            }

            writer.Close();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Vizsga[] eredmenyek = new Vizsga[20];
            FileMuveletek fileMuveletek = new FileMuveletek();

            for (int i = 0; i < eredmenyek.Length; i++)
            {
                eredmenyek[i] = new Vizsga();
            }

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Az összes vizsgázó kódja:");

            foreach (var eredmeny in eredmenyek)
            {
                stringBuilder.AppendLine(eredmeny.VizsgaKod);
            }

            fileMuveletek.WriteToFile(@"mindenvizsgazo.txt", stringBuilder.ToString());

            stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("A sikereses vizsgázók kódja:");

            foreach (var eredmeny in eredmenyek)
            {
                if (eredmeny.PontSzam > 70)
                {
                    stringBuilder.AppendLine(eredmeny.VizsgaKod);
                }
            }

            fileMuveletek.WriteToFile(@"sikeresvizsgazok.txt", stringBuilder.ToString());


            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
