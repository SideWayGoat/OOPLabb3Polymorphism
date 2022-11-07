using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb3Polymorphism
{
    public class Rectangle : Geometry
    {
        private double Lenght { get; set; }
        private double Width { get; set; }

        public Rectangle(double _lenght, double _width)
        {
            this.Lenght = _lenght;
            this.Width = _width;
        }

        public override double getArea()
        {
            return Lenght * Width;
        }
    }
}
