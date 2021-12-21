using System;

namespace ClassComplex
{
    class ClComplex
    {
        double re;
        double im;
        public ClComplex()
        {
            re = 0;
            im = 0;
        }
        public ClComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public ClComplex Add(ClComplex x)
        {
            ClComplex y = new();
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }
        public ClComplex Subtract(ClComplex x)
        //Вычитание
        {
            ClComplex y = new();
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }
        public ClComplex Multiply(ClComplex x)
        {
            ClComplex y = new();
            y.re = re * x.re - im * x.im;
            y.im = im * x.re + re * x.im;
            return y;
        }
        public static ClComplex Multiply(ClComplex x1, ClComplex x2)
        {
            ClComplex y = new();
            y.re = x1.re * x2.re - x1.im * x2.im;
            y.im = x1.im * x2.re + x1.re * x2.im;
            return y;
        }
        public double Re
        {
            get { return re; }
            set
            {
                im = value;
            }
        }
        public double Im
        {
            get { return im; }
            set
            {
                im = value;
            }
        }
        override public string ToString()
        {
            if (im < 0)
            {
                return re + "" + im + "i";
            }
            else return re + "+" + im + "i";
        }
        public void Dialogue(ClComplex x)
        {
            int choice = MyMethods.Program.InputInt("Выберите операцию с комплексными числами: 1 - сложение, 2 - вычитание, 3 - умножение");
            switch (choice)
            {
                case 1:
                    Console.WriteLine(Add(x));
                    break;
                case 2:
                    Console.WriteLine(Subtract(x));
                    break;
                case 3:
                    Console.WriteLine(Multiply(x));
                    break;
                default:
                    Console.WriteLine("Необходимо ввести числа от 1 до 3");
                    break;
            }
        }
        public ClComplex DialogueReturn(ClComplex x)
        {
            int choice = MyMethods.Program.InputInt("Выберите операцию с комплексными числами: 1 - сложение, 2 - вычитание, 3 - умножение");
            switch (choice)
            {
                case 1:
                    return Add(x);
                case 2:
                    return (x);
                case 3:
                    return Multiply(x);
                default:
                    Console.WriteLine("Необходимо ввести числа от 1 до 3");
                    return null;
            }
        }
    }
}

