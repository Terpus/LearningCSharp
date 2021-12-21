using System;
using MyMethods;
//С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int input;
            string evenNumbers = null;
            do
            {
                input = MyMethods.Program.InputInt("Введите число. Для остановки введите 0.");
                if (input % 2 != 0 && input > 0)
                {
                    evenNumbers += input.ToString() + " ";
                    sum += input;
                }
            } while (input != 0);
            //Не видел смысла в выводе через tryParse, потому что проверка уже делается на вводе
            Console.WriteLine($"Нечётные положительные числа: {evenNumbers}");
            Console.WriteLine($"Сумма всех нечётных положительных чисел равна: {sum}");
        }
    }
}
