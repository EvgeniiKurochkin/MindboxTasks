using CalculatingSquare;
using NUnit.Framework;

namespace CalculatingSquareTest
{
    public class TriangleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-1, 0, 1)]
        [TestCase(1, -1, 0)]
        [TestCase(0, 1, -1)]
        [TestCase(-1, -1, -1)]
        [TestCase(0, 0, 0)]
        public void TriangleSideTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
            
        }

        [Test]
        public void TriangleSquareTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var triangleSquare = triangle.GetSquare();

            //Assert
            Assert.AreEqual(6, triangleSquare);
        }
       

        [TestCase(1, 1, 1, ExpectedResult = false)]
        [TestCase(2, 2, 3 , ExpectedResult = false)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        public bool RightTriangleTest(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            return triangle.RightTriangle;

        }
    }
}