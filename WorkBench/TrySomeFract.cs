using System;

namespace WorkBench
{
    class TrySomeFract
    {
        static void Main(string[] args)
        {
            var f1 = new Fraction.Fraction(11, 1);
            var f2 = new Fraction.Fraction(1, 11);
            Console.WriteLine(f1 / f2);
        }
    }
}
