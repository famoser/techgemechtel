using Techgemechtel.DRY.DRY.Bad.Shapes;
using Circle = Techgemechtel.DRY.DRY.Good.Shapes.Circle;

namespace Techgemechtel.DRY.DRY.Bad
{
    internal class CalculateDiameterHelper
    {
        private readonly Circle[] _cycles;
        private readonly Rectangle[] _rectangles;
        public CalculateDiameterHelper(Circle[] cycles, Rectangle[] rectangles)
        {
            _cycles = cycles;
            _rectangles = rectangles;
        }

        public double CalculateAreas()
        {
            double res = 0;
            //duplicated code 
            foreach (var cycle in _cycles)
            {
                res += cycle.GetArea();
            }
            //duplicated code 
            foreach (var rectangle in _rectangles)
            {
                res += rectangle.GetArea();
            }
            return res;
        }
    }
}
