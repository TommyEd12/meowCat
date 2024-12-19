using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meowCat
{
    public class Fraction : ICloneable, ICalculatable
    {
        private int numerator;
        private int denominator;

        
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен нулю.");

            
            if (denominator < 0)
            {
                this.numerator = -numerator;
                this.denominator = -denominator;
            }
            else
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }

            toNormalForm();
        }

        
        private void toNormalForm()
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;
        }

        
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        
        public static Fraction operator +(Fraction first, Fraction second)
        {
            int newNumerator = first.numerator * second.denominator + second.numerator * first.denominator;
            int newDenominator = first.denominator * second.denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public static Fraction operator +(Fraction first, int second)
        {
            int newNumerator = first.numerator + second * first.denominator;
            return new Fraction(newNumerator, first.denominator);
        }

        
        public static Fraction operator -(Fraction first, Fraction second)
        {
            int newNumerator = first.numerator * second.denominator - second.numerator * first.denominator;
            int newDenominator = first.denominator * second.denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public static Fraction operator -(Fraction first, int second)
        {
            int newNumerator = first.numerator - second * first.denominator;
            return new Fraction(newNumerator, first.denominator);
        }

        
        public static Fraction operator *(Fraction first, Fraction second)
        {
            return new Fraction(first.numerator * second.numerator, first.denominator * second.denominator);
        }
        public static Fraction operator *(Fraction first, int second)
        {
            return new Fraction(first.numerator * second, first.denominator);
        }

        
        public static Fraction operator /(Fraction first, Fraction second)
        {
            if (second.numerator == 0)
                throw new DivideByZeroException("Деление на ноль");

            return new Fraction(first.numerator * second.denominator, first.denominator * second.numerator);
        }
        public static Fraction operator /(Fraction first, int second)
        {
            if (second == 0)
                throw new DivideByZeroException("Деление на ноль");

            return new Fraction(first.numerator, first.denominator * second);
        }

        
        public override bool Equals(object obj)
        {
            if (obj is Fraction other)
            {
                return numerator == other.numerator && denominator == other.denominator;
            }
            return false;
        }


        
        public Object Clone()
        {
            return new Fraction(numerator, denominator);
        }

        
        public double ToDouble()
        {
            return (double)numerator / denominator;
        }

        
        public void SetNumerator(int numerator)
        {
            this.numerator = numerator;
            toNormalForm();
        }

        
        public void SetDenominator(int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен нулю.");

            if (denominator < 0)
            {
                this.numerator = -numerator;
                this.denominator = -denominator;
            }
            else
            {
                this.denominator = denominator;
            }

            toNormalForm();
        }
    }

}
