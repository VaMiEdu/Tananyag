using System;
using System.Collections.Generic;

namespace Factory
{
    public interface ITransport
    {
        public string Name { get; }
        public void Deliver();
    }

    public class Truck : ITransport
    {
        public Truck()
        {
            this.Name = $"Truck_{new Random().Next(1, 999)}";
        }

        public string Name { get; }

        public void Deliver()
        {
            Console.WriteLine($"Delivering by Truck ({Name}).");
        }
    }

    public class Ship : ITransport
    {
        public Ship()
        {
            this.Name = $"Ship_{new Random().Next(1, 999)}";
        }

        public string Name { get; }

        public void Deliver()
        {
            Console.WriteLine($"Delivering by Ship ({Name}).");
        }
    }

    public abstract class LogisticFactory
    {
        public abstract ITransport GetVehicleByType(string type);
    }

    public class ConcreteLogisticFactory : LogisticFactory
    {
        public override ITransport GetVehicleByType(string type)
        {
            switch (type)
            {
                case "T":
                    return new Truck();
                case "S":
                    return new Ship();
                default:
                    throw new ArgumentException("Not supported type: '{type}'");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConcreteLogisticFactory();

            var amazonVehicles = new List<ITransport>();

            var truck = factory.GetVehicleByType("T");
            var ship = factory.GetVehicleByType("S");

            for (int i = 0; i < 100; i++)
            {
                if (new Random().Next(1,10) > 5)
                {
                    var randomTruck = factory.GetVehicleByType("T");
                    amazonVehicles.Add(randomTruck);
                }
                else
                {
                    var randomShip = factory.GetVehicleByType("S");
                    amazonVehicles.Add(randomShip);
                }
            }

            foreach (var currentVehicle in amazonVehicles)
            {
                currentVehicle.Deliver();
            }
        }
    }
}
