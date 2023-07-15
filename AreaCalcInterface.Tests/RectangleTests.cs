using AreaCalcWithInterfaceLibrary.Figure;

namespace AreaCalcInterface.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void GetArea_Radius5_Returns78_53982()
        {
            // Arrange
            double radius = 5;
            double expected = 78.53982;

            // Act
            var rectangle = new Rectangle(radius);
            var area = rectangle.GetArea();

            // Assert
            Assert.AreEqual(expected, area);
        }
    }
}
