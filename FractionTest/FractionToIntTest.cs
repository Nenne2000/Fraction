using System;
using Fraction;
using NUnit.Framework;

namespace FractionTest
{
    class FractionToIntTest
    {
        [Test]
        public void FractToInt()
        {
            var f1 = new Fraction.Fraction(0, 1);
            var intValue = f1.ToInt();
            Assert.That(intValue.Equals(0));
        }

        [Test]
        public void IntConversionViolation()
        {
            var f1 = new Fraction.Fraction(5, 12);
            Assert.That(() => f1.ToInt(), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }
    }
}
