using System;
using NUnit.Framework;


namespace FractionTest
{
    class FractionToIntTest
    {

        [Test]
        public void IntToFract()
        {
            var f1 = new Fraction.Fraction(42);
            Fraction.Fraction f2 = 42;
            Assert.AreEqual(f1, f2);
        }

        [Test]
        public void IntToFractZero()
        {
            var f1 = new Fraction.Fraction();
            Fraction.Fraction f2 = 0;
            Assert.AreEqual(f1, f2);
        }

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
            var f1 = new Fraction.Fraction(42, 11);
            Assert.That(() => f1.ToInt(), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }
    }
}
