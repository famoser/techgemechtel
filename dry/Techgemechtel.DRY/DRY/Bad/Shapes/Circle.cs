using System;

namespace Techgemechtel.DRY.DRY.Bad.Shapes
{
    internal class Circle
    {
        private readonly double _radius;
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
