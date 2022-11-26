using System;
using System.Collections.Generic;
using System.Text;

namespace Intro
{
    internal class Order
    {
        public Order(string personName, string pizzaName, bool? isTomato)
        {
            PersonName = personName;
            PizzaName = pizzaName;
            IsTomato = isTomato;
        }

        public string PersonName { get; }
        public string PizzaName { get; }
        public bool? IsTomato { get; }

        public override string ToString()
        {
            return $"Név: {PersonName}, pizza: {PizzaName}, tejfölös? {!IsTomato}";
        }
    }
}
