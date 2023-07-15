using AreaCalcWithInterfaceLibrary.Figure;

namespace AreaCalcInterface.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetArea_Sides3_4_5_Returns6()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;

            double expected = 6;

            // Act
            var triangle = new Triangle(a, b, c);
            var area = triangle.GetArea();

            // Assert
            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        public void IsTriangle_Sides3_4_5_ReturnsTrue()
        {
            // Arrange
            double a = 3;
            double b = 4;
            double c = 5;

            // Act
            var triangle = new Triangle(a, b, c);
            var result = triangle.IsTriangle();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsTriangle_Sides2_3_4_ReturnsFalse()
        {
            // Arrange
            double a = 2;
            double b = 3;
            double c = 4;

            // Act
            var triangle = new Triangle(a, b, c);
            var result = triangle.IsTriangle();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
