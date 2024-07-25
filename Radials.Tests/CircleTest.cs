using Radials;
namespace Radials.Tests
{
    public class CircleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ZeroTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(0));
        }
        [Test]
        public void NegativeTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-1));
        }
        [Test]
        public void SquareTest()
        {
            var R = 3;
            Circle c = new(R);
            var exp = Math.PI * Math.Pow(R, 2);
            var act = c.Square();
            Assert.That(act, Is.EqualTo(exp));
        }
    }
}