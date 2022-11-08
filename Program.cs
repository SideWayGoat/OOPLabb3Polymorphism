using System;

namespace OOPLabb3Polymorphism
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Geometry geometry;
            geometry = new Circle(4);
            Console.WriteLine("Area of the circle: " + geometry.getArea() + " CM");

            geometry = new Square(4);
            Console.WriteLine("Area of the square : " + geometry.getArea() + " CM");

            geometry = new Rectangle(4, 5);
            Console.WriteLine("Area of rectangle : " + geometry.getArea() + " CM");


        }
    }
}
