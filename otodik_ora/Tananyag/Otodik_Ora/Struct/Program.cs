using System;

namespace Struct
{
    public class Passport
    {
        public string Number { get; set; }
        public DateTime Expiration { get; set; }
        public string Country { get; set; }

        public readonly DateTime szulinap;

        public Passport()
        {
            szulinap = new DateTime(1990, 02, 19);
        }
    }

    public struct PassportAsStruct
    {
        public string Number { get; set; }
        public DateTime Expiration { get; set; }
        public string Country { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack & heap (verem & kupac)
            //LIFO & FIFO (last in first out & first in first out)

            Passport elsoPassport = new Passport();
            elsoPassport.Number = "123";

            Passport masodikPassport = elsoPassport;
            masodikPassport.Number = "456";

            PassportAsStruct passportAsStruct = new PassportAsStruct();
            passportAsStruct.Number = "12345";

            PassportAsStruct passportAsStruct2 = passportAsStruct;
            passportAsStruct2.Number = "12";
        }
    }
}
