using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class RationalNumbers
    {
        int _numerator, _denominator;


        public RationalNumbers(int numerator,int denominator) 
        {
            _numerator = numerator;
            _denominator = denominator;
        }
        public override string ToString()
        {
            string s = _numerator+"/"+_denominator;
            return (s);
        }
 
        public static int FindGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override bool Equals(object obj)
        {
            return obj is RationalNumbers numbers &&
                   _numerator == numbers._numerator &&
                   _denominator == numbers._denominator;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_numerator, _denominator);
        }

        public static bool operator ==(RationalNumbers rn1, RationalNumbers rn2)
        {
            double x = (double)rn1._numerator /(double) rn1._denominator;
            double y = (double)rn2._numerator /(double) rn2._denominator;
            if (x == y)
                return true;
            else
                return false;
        }
        public static bool operator !=(RationalNumbers rn1, RationalNumbers rn2)
        {
            double x =(double) rn1._numerator /(double) rn1._denominator;
            double y = (double)rn2._numerator /(double) rn2._denominator;
            if (x != y)
                return true;
            else
                return false;
        }
        public static bool operator <(RationalNumbers rn1, RationalNumbers rn2)
        {
            double x = (double)rn1._numerator / (double)rn1._denominator;
            double y = (double)rn2._numerator / (double)rn2._denominator;
            if (x < y)
                return true;
            else
                return false;
        }
        public static bool operator >(RationalNumbers rn1, RationalNumbers rn2)
        {
            double x = (double)rn1._numerator / (double)rn1._denominator;
            double y = (double)rn2._numerator / (double)rn2._denominator;
            if (x > y)
                return true;
            else
                return false;
        }
        public static bool operator <=(RationalNumbers rn1, RationalNumbers rn2)
        {
            double x = (double)rn1._numerator / (double)rn1._denominator;
            double y = (double)rn2._numerator / (double)rn2._denominator;
            if (x <= y)
                return true;
            else
                return false;
        }
        public static bool operator >=(RationalNumbers rn1, RationalNumbers rn2)
        {
            double x = (double)rn1._numerator / (double)rn1._denominator;
            double y = (double)rn2._numerator / (double)rn2._denominator;
            if (x >= y)
                return true;
            else
                return false;
        }

        public static RationalNumbers operator +(RationalNumbers rn1,RationalNumbers rn2)
        {
            int sumDenominator = rn1._denominator * rn2._denominator;
            int sumNumerator = rn1._numerator * rn2._denominator + rn2._numerator * rn1._denominator;
            int temp=FindGreatestCommonDivisor(sumDenominator, sumNumerator);
            sumDenominator /= temp;
            sumNumerator /= temp;
            return new RationalNumbers(sumNumerator,sumDenominator);            
        }
        public static RationalNumbers operator -(RationalNumbers rn1, RationalNumbers rn2)
        {
            int sumDenominator = rn1._denominator * rn2._denominator;
            int sumNumerator = rn1._numerator * rn2._denominator - rn2._numerator * rn1._denominator;
            int temp = FindGreatestCommonDivisor(sumDenominator, sumNumerator);
            sumDenominator /= temp;
            sumNumerator /= temp;
            return new RationalNumbers(sumNumerator, sumDenominator);
        }
        public static RationalNumbers operator *(RationalNumbers rn1, RationalNumbers rn2)
        {
            int sumDenominator = rn1._denominator * rn2._denominator;
            int sumNumerator = rn1._numerator * rn2._numerator;
            int temp = FindGreatestCommonDivisor(sumDenominator, sumNumerator);
            sumDenominator /= temp;
            sumNumerator /= temp;
            return new RationalNumbers(sumNumerator, sumDenominator);
        }
        public static RationalNumbers operator /(RationalNumbers rn1, RationalNumbers rn2)
        {
            int sumDenominator = rn1._denominator * rn2._numerator;
            int sumNumerator = rn1._numerator * rn2._denominator;
            int temp = FindGreatestCommonDivisor(sumDenominator, sumNumerator);
            sumDenominator /= temp;
            sumNumerator /= temp;
            return new RationalNumbers(sumNumerator, sumDenominator);
        }

    }
}
