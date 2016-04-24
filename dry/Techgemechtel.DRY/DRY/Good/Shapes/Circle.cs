using System;

namespace Techgemechtel.DRY.DRY.Good.Shapes
{
    internal class Circle : IShape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
