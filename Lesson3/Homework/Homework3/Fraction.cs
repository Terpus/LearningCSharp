using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Fraction
    {
        int nom, denom, whole;
        public Fraction()
        {
        }
        public Fraction(int nom, int denom, int whole = 0)
        {
            this.nom = nom;
            this.denom = denom;
            this.whole = whole;
            if (denom==0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
        }
        public int Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Denom
        {
            get { return denom; }
            set { denom = value; }
        }
        public int Whole
        {
            get { return whole; }
            set { whole = value; }
        }
        public double Decimal
        {
            get
            {
                return (double)nom/denom;
            }
        }
        public Fraction Add(Fraction x)
        {
            Fraction res = new();
            int lcd;
            int mult1, mult2;
            if (denom == x.denom)
            {
                res.nom = nom + x.nom;
                res.denom = denom;
            }
            else
            {
                lcd = LowComDenom(x.denom);
                mult1 = lcd / denom;
                mult2 = lcd / x.denom;
                res.nom = nom * mult1 + x.nom * mult2;
                res.denom = lcd;
            }
            return res.Reduction();
        }
        public Fraction Subtract(Fraction x)
        {
            Fraction res = new();
            int lcd;
            int mult1, mult2;
            if (denom == x.denom)
            {
                res.nom = nom - x.nom;
                res.denom = denom;
            }
            else
            {
                lcd = LowComDenom(x.denom);
                mult1 = lcd / denom;
                mult2 = lcd / x.denom;
                res.nom = nom * mult1 - x.nom * mult2;
                res.denom = lcd;
            }
            return res.Reduction();
        }
        public Fraction Multiply(Fraction x)
        {
            Fraction res = new();
            res.nom = nom * x.nom;
            res.denom = denom * x.denom;
            return res.Reduction();
        }
        public Fraction Divide(Fraction x)
        {
            Fraction res = new();
            res.nom = nom * x.denom;
            res.denom = denom * x.nom;
            return res.Reduction();
        }
        public int LowComDenom(int denom)
        {
            int lcm = 1;
            int max;
            if (this.denom > denom)
            {
                max = this.denom;
            }
            else max = denom;
            for (int i = max; i <= this.denom * denom; i++)
            {
                if (i % this.denom == 0 && i % denom == 0)
                {
                    lcm = i;
                    break;
                }
            }
            return lcm;
        }
        public Fraction Reduction()
        {
            int divider = 1;
            Fraction y = new();
            for (int i = denom; i >= 2; i--)
            {
                if (nom % i == 0 && denom % i == 0)
                {
                    divider = i;
                    y.nom = nom / divider;
                    y.denom = denom / divider;
                    break;
                }
                else
                {
                    y.nom = this.nom;
                    y.denom = this.denom;
                }

            }
            return y;
        }
        public static bool TryParse(Fraction x, out int whole)
        {
            whole = 0;
            if (x.denom == 1)
            {
                whole = x.nom;
                return true;
            }
            else return false;
        }
        override public string ToString()
        {
            return nom + "/" + denom;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
