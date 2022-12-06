using CalculatingSquare;
using NUnit.Framework;

namespace CalculatingSquareTest
{
    public class CircleTest
    {
        [Test]
        public void CircleRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        }

        [Test]
        public void GetSquareTest()
        {
            var circle = new Circle(5);

            var square = circle.GetSquare();

            Assert.AreEqual(square, 78.539816339744831);
        }
    }
}