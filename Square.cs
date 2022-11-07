using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb3Polymorphism
{
    public class Square : Geometry
    {
        public double Side { get; set; }

        public Square(double _side)
        {
            this.Side = _side;
        }

        public override double getArea()
        {
            return (Side * Side);
        }
    }
}
