using System;
//2. Написать метод подсчета количества цифр числа.
namespace Homework2
{
    class Program
    {
        private static int CountDigits(int number)
        {
            int d = 0;
            while (number != 1)
            {

                number = number / 10;
                d++;
            }
            return d;
        }
        static void Main(string[] args)
        {
            int a = MyMethods.Program.InputInt("Введите число");
            Console.WriteLine(CountDigits(a));
        }
    }
}
