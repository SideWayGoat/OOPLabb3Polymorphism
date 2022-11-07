using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb3Polymorphism
{
    public class Circle : Geometry
    {
        public double Radius { get; set; }

        public Circle(double _radius)
        {
            this.Radius = _radius;
        }

        public override double getArea()
        {
            return (Radius * Radius * Math.PI);
        }
    }
}
