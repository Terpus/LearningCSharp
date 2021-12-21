using System;
//*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
//* Добавить свойства типа int для доступа к числителю и знаменателю;
//*Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
//**Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
//***Добавить упрощение дробей.
namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new(3,5);
            Fraction b = new(4,7);
            //**Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
            //Fraction c = new(5,0);
            Fraction d = new(6,21);
            Fraction addition = a.Add(b);
            Fraction subtraction = a.Subtract(b);
            Fraction multiplication = a.Multiply(b);
            Fraction division = a.Divide(b);
            addition.Print();
            subtraction.Print();
            multiplication.Print();
            division.Print();
            //* Добавить свойства типа int для доступа к числителю и знаменателю;
            Console.WriteLine(a.Nom);
            Console.WriteLine(b.Denom);
            //*Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
            Console.WriteLine(a.Decimal);
            //***Добавить упрощение дробей.
            Console.WriteLine(d.Reduction());
        }
    }
}
