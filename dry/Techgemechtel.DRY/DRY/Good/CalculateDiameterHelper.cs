using Techgemechtel.DRY.DRY.Good.Shapes;

namespace Techgemechtel.DRY.DRY.Good
{
    internal class CalculateDiameterHelper
    {
        private readonly IShape[] _shapes;
        public CalculateDiameterHelper(IShape[] shapes)
        {
            _shapes = shapes;
        }

        public double CalculateAreas()
        {
            double res = 0;
            //duplicated code removed!
            foreach (var shape in _shapes)
            {
                res += shape.GetArea();
            }
            return res;
        }
    }
}
