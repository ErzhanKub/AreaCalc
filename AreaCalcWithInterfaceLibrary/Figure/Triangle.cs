using AreaCalcWithInterfaceLibrary.Interface;

namespace AreaCalcWithInterfaceLibrary.Figure
{
    public class Triangle : IFigure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double GetArea()
        {
            var p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsTriangle()
        {
            return _a * _a + _b * _b == _c * _c || _a * _a + _c * _c == _b * _b || _b * _b + _c * _c == _a * _a;
        }

        public void PrintIsTriagle()
        {
            if (IsTriangle())
            {
                Console.WriteLine("Треугольник является прямоугольным.");
            }
            else
            {
                Console.WriteLine("Треугольник не является прямоугольным.");
            }
        }
    }
}
