using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radials.Tests
{
    internal class QuadroTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ZeroTest()
        {
            Assert.Catch<ArgumentException>(() => new Quadro(0));
        }
        [Test]
        public void NegativeTest()
        {
            Assert.Catch<ArgumentException>(() => new Quadro(-1));
        }
        [Test]
        public void SquareTest()
        {
            var line = 3;
            Quadro c = new(line);
            var exp = Math.Pow(line,2);
            var act = c.Square();
            Assert.That(act, Is.EqualTo(exp));
        }
    }
}
