using System;
using MyMethods;
//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

namespace Homework3
{
    class Program
    {
        private static int SumEvenPositive()
        {
            int sum = 0;
            int input;
            do
            {
                input = MyMethods.Program.InputInt("Введите число, после ввода нажимая Enter. Для прекращения введите 0");
                sum += input;
            } while (input != 0);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Сумма введенных чисел: {SumEvenPositive()}");
        }
    }
}
