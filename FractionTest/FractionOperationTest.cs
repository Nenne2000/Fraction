using System;
using Fraction;
using NUnit.Framework;

namespace FractionTest
{
    [TestFixture]
    class FractionOperationTest
    {
        [Test]
        public void Add()
        {
            var f1 = new Fraction.Fraction(1, 2);
            var f2 = new Fraction.Fraction(2, 5);
            var res = new Fraction.Fraction(9, 10);
            Assert.That(res.Equals(f1 + f2));
        }

        [Test]
        public void Subtract()
        {
            var f1 = new Fraction.Fraction(33, 7);
            var f2 = new Fraction.Fraction(4);
            var res = new Fraction.Fraction(-5, 7);
            Assert.That(res.Equals(f2 - f1));
        }

        [Test]
        public void Multiplication()
        {
            var f1 = new Fraction.Fraction(11);
            var f2 = new Fraction.Fraction(1, 11);
            var res = new Fraction.Fraction(1);
            Assert.That(res.Equals(f2 * f1));
        }

        [Test]
        public void MultiplicationZero()
        {
            var f1 = new Fraction.Fraction(42);
            var f2 = new Fraction.Fraction(0);
            var res = new Fraction.Fraction();
            Assert.That(res.Equals(f2 * f1));
        }

        [Test]
        public void Division()
        {
            var f1 = new Fraction.Fraction(33, 42);
            var f2 = new Fraction.Fraction(111, 8);
            var res = new Fraction.Fraction(44, 777);
            var aux = f1 / f2;
            Assert.That(res.Equals(aux));
        }

        [Test]
        public void DivisionZero()
        {
            var f1 = new Fraction.Fraction(42);
            var f2 = new Fraction.Fraction(0);
            Assert.That(() => f1 / f2 , Throws.InstanceOf<DivideByZeroException>());
        }
         
    }
}
