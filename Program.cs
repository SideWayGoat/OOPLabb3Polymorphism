using System;

namespace OOPLabb3Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4);
            Console.WriteLine("Area of the circle: " + circle.getArea() + " CM");

            Square square = new Square(4);
            Console.WriteLine("Area of the square : " + square.getArea() + " CM");

            Rectangle rectangle = new Rectangle(4, 5);
            Console.WriteLine("Area of rectangle : " + rectangle.getArea() + " CM");

        }
    }
}
