using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Shape osztály | Draw metódus");
        }

        public virtual void Draw2()
        {
            Console.WriteLine("Shape osztály | Draw2 metódus");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle osztály | Draw metódus");
            base.Draw();
        }

        public sealed override void Draw2()
        {
            Console.WriteLine("Shape osztály | Draw2 metódus");
        }
    }

    public class Orb : Circle
    {
        double x = Math.PI;

        public void Draw2()
        {
            Console.WriteLine("Orb osztály | Draw2 metódus");
        }
    }

    public static class Rectangle
    {
        public static void Draw()
        {
            Console.WriteLine("Rectangle osztály | Draw metódus");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Circle circle = new Circle();
            //Rectangle rectangle = new Rectangle();  // Static class, nem lehet példányosítani

            Rectangle.Draw();

            circle.X = 10;

            circle.Draw2();

            //shape.Draw();
            //circle.Draw();
            //rectangle.Draw();

            List<Shape> alakzatok = new List<Shape>();
            alakzatok.Add(shape);
            alakzatok.Add(circle);

            //alakzatok.Add(rectangle);

            foreach (var alakzat in alakzatok)
            {
                alakzat.Draw();
            }
        }
    }
}
