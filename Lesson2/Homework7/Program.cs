using System;
namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(1, 10);
            Console.WriteLine(Sum(5, 15));
        }

        private static void PrintNumbers(int a, int b)
        //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        {
            if (a >= b) return;
            Console.WriteLine(a);
            PrintNumbers(a + 1, b);
        }
        private static int Sum(int a, int b)
        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        {
            int sum=a;
            if (a >= b) return sum;
            sum += Sum(a + 1, b);
            return sum;
        }
    }
}
