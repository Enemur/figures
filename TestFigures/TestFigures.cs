using System.Runtime.InteropServices;
using NUnit.Framework;
using Figures;

namespace TestCalculatingSquareOfFigure
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PassingTestCalcSquareTriangle1()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.CalculateSquare());
        }

        [Test]
        public void FailingTestCalcSquareTriangle1()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(4, triangle.CalculateSquare());
        }

        [Test]
        public void PassingTestCalcSquareTriangle2()
        {
            var triangle = new Triangle(6, 8, 10);
            Assert.AreEqual(24, triangle.CalculateSquare());
        }

        [Test]
        public void PassingTestCalcSquareCircle1()
        {
            var circle = new Circle(2);
            Assert.AreEqual(12.566370614359172d, circle.CalculateSquare());
        }

        [Test]
        public void FailingTestCalcSquareCircle1()
        {
            var circle = new Circle(2);
            Assert.AreEqual(10, circle.CalculateSquare());
        }

        [Test]
        public void PassingTestIsRightTriangle1()
        {
            var triangle = new Triangle(6, 8, 10);
            Assert.AreEqual(true, triangle.IsRight());
        }

        [Test]
        public void PassingTestIsRightTriangle2()
        {
            var triangle = new Triangle(4, 3, 5);
            Assert.AreEqual(true, triangle.IsRight());
        }

        [Test]
        public void FailingTestIsRightTriangle2()
        {
            var triangle = new Triangle(4, 3, 5);
            Assert.AreEqual(false, triangle.IsRight());
        }
    }
}