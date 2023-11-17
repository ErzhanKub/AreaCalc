using AreaCalcLibrary.ClassBase;
namespace AreaCalcLibrary.Figure
{
    public class Rectangle : Shape
    {
        private readonly double _radius;

        public Rectangle(double ragius)
        {
            _radius = ragius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
