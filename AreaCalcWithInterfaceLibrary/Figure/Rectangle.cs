using AreaCalcWithInterfaceLibrary.Interface;

namespace AreaCalcWithInterfaceLibrary.Figure
{
    public class Rectangle : IFigure
    {
        private readonly double _radius;

        public Rectangle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
