using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb3Polymorphism
{
    public class Geometry
    {
        protected readonly double Area;

        public virtual double getArea()
        {
            return Area;
        }
    }
}
