using AreaCalcWithInterfaceLibrary.Figure;
using AreaCalcWithInterfaceLibrary.Interface;

namespace AreaCalcWithInterfaceLibrary.Factory
{
    public static class FigureFactory
    {
        public static IFigure CreateRectangle(double radius)
        {
            return new Rectangle(radius);
        }

        public static IFigure CreateTriangle(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }
    }
}
