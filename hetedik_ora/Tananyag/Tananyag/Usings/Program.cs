using System;
using System.IO;
using Usings;

namespace Usings
{
    class Kutya : IDisposable
    {
        public void Dispose()
        {

        }
        //public void Dispose()
        //{
        //    // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //    Dispose(disposing: true);
        //    GC.SuppressFinalize(this);
        //}
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        string szoveg = "Do not change this code. Put cleanup code in 'Dispose(bool disposing)' meth";

        StringReader reader = new StringReader(szoveg);

        using (var stringReader = new StringReader(szoveg))
        {
            Console.WriteLine(stringReader.ReadLine());
        }

        Console.WriteLine("Hello World!");
    }
}
