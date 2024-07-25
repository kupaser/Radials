using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework.Internal;

namespace Radials.Tests
{
    internal class TriangleTest
    {
        [SetUp]
        public void Setup() { }

        [TestCase(3, 0, 5)]
        [TestCase(0, 4, 5)]
        [TestCase(3, 4, 0)]
        [TestCase(0, 0, 0)]
        public void ZeroTest(double one, double two, double three)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(one, two, three));
        }
        [TestCase(-3, 4, 5)]
        [TestCase(3, -4, 5)]
        [TestCase(3, 4, -5)]
        [TestCase(-3, -4, -5)]
        public void NegativeTest(double one, double two, double three)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(one, two, three));
        }
        [TestCase(2, 2, 5)]
        [TestCase(1, 1, 3)]
        [TestCase(1, 2, 3)]
        [TestCase(5, 5, 10)]
        public void IsReal(double one, double two, double three)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(one, two, three));
        }
        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(5, 12, 13, ExpectedResult = true)]
        [TestCase(7, 10, 12, ExpectedResult = false)]
        [TestCase(8, 9, 13, ExpectedResult = false)]
        public bool IsRight(double one, double two, double three)
        {
            Triangle tr = new(one, two, three);
            return tr.IsRight();
        }
        [Test]
        public void SquareTest()
        {
            Triangle triangle = new(3, 4, 5);
            //Прямоугольный
            var exp = 3 * 4 / 2;
            var act = triangle.Square();
            Assert.That(act, Is.EqualTo(exp));
        }
    }
}
