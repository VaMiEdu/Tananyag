using System;
using System.Collections.Generic;
using System.Text;

namespace Nyilvantarto.Entities
{
    public struct Passport
    {
        public string Number { get; set; }
        public DateTime Expiration { get; set; }
        public string Country { get; set; }
    }
}
