using System;
using System.IO;
using System.Text;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamReader
            StreamReader streamReader = new StreamReader(@"pelda.txt");
            string fileTartalma = string.Empty;

            StringBuilder stringBuilder = new StringBuilder(); 

            //string sor = streamReader.ReadLine();
            //bool utolsoSor = streamReader.EndOfStream;

            //streamReader.Close();

            while (!streamReader.EndOfStream)
            {
                stringBuilder.AppendLine(streamReader.ReadLine());
                //string s = streamReader.ReadLine();
                //Console.WriteLine(s);
            }

            fileTartalma = stringBuilder.ToString();

            //StreamWriter
            StreamWriter streamWriter = new StreamWriter(@"pelda2.txt", true);

            for (int i = 0; i < fileTartalma.Length; i++)
            {
                streamWriter.Write(fileTartalma[i]);
            }

            streamWriter.Close();

            using StreamWriter writer = new StreamWriter(@"pelda2.txt");

            for (int i = 0; i < fileTartalma.Length; i++)
            {
                writer.Write(fileTartalma[i]);
            }

            writer.Close();


            //File class

            var szoveg = File.ReadAllLines("pelda2.txt");
        }
    }
}
