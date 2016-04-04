namespace Techgemechtel.DRY.DRY.Bad.Shapes
{
    internal class Rectangle
    {
        private readonly double _width;
        private readonly double _height;
        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double GetArea()
        {
            return _width * _height;
        }
    }
}
