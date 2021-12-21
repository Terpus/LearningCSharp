namespace StructureComplex
{
    struct StrComplex
    {
        double re, im;
        public StrComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public StrComplex Add(StrComplex x)
        {
            StrComplex y;
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }
        public StrComplex Subtract(StrComplex x)
        //Вычитание
        {
            StrComplex y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }
        public StrComplex Multi(StrComplex x)
        {
            StrComplex y;
            y.re = re * x.re - im * x.im;
            y.im = re * x.im + im * x.re;
            return y;
        }
        override public string ToString()
        {
            if (im < 0)
            {
                return re + "" + im + "i";
            }
            else return re + "+" + im + "i";
        }
    }
}
