using System;

public class Complex
{
	public double im, re;
	public Complex()
	{
	}
	public Complex Plus(Complex x2)
    {
		Complex x3 = new Complex();
		x3.im = x2.im + this.im;
		x3.re = x2.re + this.re;
		return x3;
    }
	public string ToString()
    {
		return re + " + " + im + "i";
    }
}
