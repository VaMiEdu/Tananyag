using System;

namespace SzovegekFormazasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pénzzel kapcsolatos formázások

            Console.WriteLine("Pénz: {0:C1}", 3148);
            Console.WriteLine("Százalék: {0:P3}", 0.123);
            Console.WriteLine("Általános: {0:G}", 12345);
            Console.WriteLine("Hexa: {0:X}", 255);

            //Idővel kapcsolatos formázások

            var ido = DateTime.Now;

            Console.WriteLine("{0:D}", ido);
            Console.WriteLine("{0:t}", ido);
            Console.WriteLine("{0:T}", ido);
            Console.WriteLine("{0:f}", ido);
            Console.WriteLine("{0:F}", ido);
            Console.WriteLine("{0:Y}", ido);
        }
    }
}

