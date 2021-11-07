using System;
using Fraction;
using NUnit.Framework;

namespace FractionTest
{
    [TestFixture]
    class FractionToStringTest
    {
        [Test]
        public void NormalConversion()
        {
            var n = 7;
            var d = 15;
            var f = new Fraction.Fraction(n, d);
            Assert.That(f.ToString(), Is.EqualTo("7/15"));
        }

        [Test]
        public void DenIsOne()
        {
            var n = 7;
            var d = 1;
            var f = new Fraction.Fraction(n, d);
            Assert.That(f.ToString(), Is.EqualTo("7"));
        }

        [Test]
        public void NormalizeConversion()
        {
            var n = 11;
            var d = 22;
            var f = new Fraction.Fraction(n, d);
            Assert.That(f.ToString(), Is.EqualTo("1/2"));
        }

        [Test]
        public void NormalizeSignConversion()
        {
            var n = 5;
            var d = -2;
            var f = new Fraction.Fraction(n, d);
            Assert.That(f.ToString(), Is.EqualTo("-5/2"));
        }
    }
}
