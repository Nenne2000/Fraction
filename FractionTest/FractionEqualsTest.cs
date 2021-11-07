using System;
using Fraction;
using NUnit.Framework;

namespace FractionTest
{
    class FractionEqualsTest
    {
        [Test]
        public void ZeroIsEqual()
        {
            var f1 = new Fraction.Fraction(0, 2);
            var f2 = new Fraction.Fraction(0);
            Assert.That(f1.Equals(f2));
        }

        [Test]
        public void NormalizeIsEqual()
        {
            var f1 = new Fraction.Fraction(1, 2);
            var f2 = new Fraction.Fraction(2, 4);
            Assert.That(f1.Equals(f2));
        }

    }
}
