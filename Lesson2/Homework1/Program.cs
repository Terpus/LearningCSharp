using System;
using MyMethods;
//1 .Написать метод, возвращающий минимальное из трёх чисел
namespace Homework1
{
    class Program
    {
        private static int Min(int a, int b, int c)
        {
            if (a < b && a < c) return a;
            else
            if (b < c) return b;
            else return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа по очереди, нажимая Enter после ввода.");
            int a = MyMethods.Program.InputInt("Введите первое число");
            int b = MyMethods.Program.InputInt("Введите второе число");
            int c = MyMethods.Program.InputInt("Введите третье число");
            Console.WriteLine($"Наименьшее из трех чисел: {Min(a, b, c)}");
        }
    }
}
