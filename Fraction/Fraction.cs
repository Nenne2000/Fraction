using System;
using System.Data.Common;

/* SAMUELE CREA FRACTION IN C# WITH TEST IN NUnit FRAMEWORK AND RESHARPER */
namespace Fraction {
    public class Fraction
    {
        public int Num { get; }
        public int Den { get; }

        //CONSTRUCTORS (3)
        public Fraction()
        {
            Num = 0;
            Den = 1;
        }
        public Fraction(int n)
        {
            Num = n;
            Den = 1;
        }
        public Fraction(int n, int d)
        {
            if (0 == d) throw new ArgumentOutOfRangeException();
            Normalizefraction(ref n, ref d);
            Num = n;
            Den = d;
        }

        private static void Normalizefraction(ref int n, ref int d)
        {
            var Gcd = 0;
            if ((n < 0 && d < 0) || (n > 0 && d < 0))
            {
                n = -n;
                d = -d;
            }

            for (var x = 1; x <= d; x++)
                if ((n % x == 0) && (d % x == 0)) Gcd = x;
            if (Gcd == 0) return;
            else {
                n /= Gcd;
                d /= Gcd;
            }
        }


        //----
        //OPERATION (+,-,*,/)
        public static Fraction operator +(Fraction a, Fraction b)
        {
            var newNum = a.Num * b.Den + b.Num * a.Den;
            var newDen = a.Den * b.Den;
            Normalizefraction(ref newNum, ref newDen);
            return new Fraction(newNum, newDen);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            var newNum = a.Num * b.Den - b.Num * a.Den;
            var newDen = a.Den * b.Den;
            Normalizefraction(ref newNum, ref newDen);
            return new Fraction(newNum, newDen);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            var newNum = a.Num * b.Num;
            var newDen = a.Den * b.Den;
            if (0 == newNum) return new Fraction(0);
                Normalizefraction(ref newNum, ref newDen);
            return new Fraction(newNum, newDen);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            var newNum = a.Num * b.Den;
            var newDen = a.Den * b.Num;

            if (newDen == 0) throw new DivideByZeroException();

            Normalizefraction(ref newNum, ref newDen);
            return new Fraction(newNum, newDen);
        }
        //----
        //TO_STRING METHOD
        public override string ToString()
        {
            if (1 == Den) return Num.ToString();
            return Num.ToString() + "/" + Den.ToString();
        }
        //----
        //EQUALS METHOD (equals, ==, != and GetHashCode because visual studio require that if i override the equals method)
        public override bool Equals(object obj)
        {
            Fraction other = obj as Fraction;
            if (0 == Num && 0 == other.Num) return true;
            return (Num == other.Num && Den == other.Den);
        }

        public override int GetHashCode()
        {
            return Num * Den;
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.Equals(f2);
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !f1.Equals(f2);
        }
        //----
        //TO_INT METHOD
        public int ToInt()
        { 
            if (1 != Den) throw new ArgumentOutOfRangeException();
            return Num;
        }
        //----
    }
}
