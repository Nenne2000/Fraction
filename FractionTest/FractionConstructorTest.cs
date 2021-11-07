using System;
using Fraction;
using NUnit.Framework;

namespace FractionTest {
    [TestFixture]
    public class FractionConstructorTest
    {
        [Test]

        public void TrivialCase()
        {
            var num = 5;
            var den = 43;
            var f = new Fraction.Fraction(num, den);
            Assert.Multiple(()=> {
                Assert.That(f.Num, Is.EqualTo(5));
                Assert.That(f.Den, Is.EqualTo(43));
            });
        }

        [Test]
        public void OnlyNumerator()
        {
            var n = 5;
            var f = new Fraction.Fraction(n);
            Assert.That(f.Num, Is.EqualTo(5));
        }

        [Test]
        public void NoArgument()
        {
            var f = new Fraction.Fraction();
            Assert.That(f.Num, Is.EqualTo(0));
        }

        [Test]
        public void TrySemplification()
        {
            var n = 2;
            var d = 4;
            var f1 = new Fraction.Fraction(n, d);
            var f2 = new Fraction.Fraction(1, 2);
            Assert.That(f1.Equals(f2));

        }

        [Test]
        public void TryNormalizeSign()
        {
            var n = 1;
            var d = -1;
            var f1 = new Fraction.Fraction(n, d);
            var f2 = new Fraction.Fraction(-1, 1);
            Assert.That(f1.Equals(f2));

        }
        [Test]
        public void ZeroDenThrows()
        {
            Assert.That( ()=> new Fraction.Fraction(7,0), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }
    }
}
