using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb3Polymorphism
{
    public class Circle : Geometry
    {
        private double Radius { get; set; }

        public Circle(double _radius)
        {
            this.Radius = _radius;
        }

        public override double getArea()
        {
            return Math.Round(Radius * Radius * Math.PI, 2);
        }
    }
}
