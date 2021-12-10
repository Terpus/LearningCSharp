using System;

namespace Homework4
{
    class Program
    {
        private static int PromptInt(string text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            //Терпинов Борис
            //Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.
            //а) с использованием третьей переменной;
            int a = PromptInt("Введите значение первой переменной");
            int b = PromptInt("Введите значение второй переменной");
            int c;
            Console.WriteLine($"Переменные {a} и {b}");
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"Переменные {a} и {b} поменяли местами");
            //б) *без использования третьей переменной.
            int x = PromptInt("Введите значение первой переменной");
            int y = PromptInt("Введите значение второй переменной");
            Console.WriteLine($"Переменные {x} и {y}");
            x = x + y;
            y = x - y;
            x -= y;
            Console.WriteLine($"Переменные {x} и {y} поменяли местами");
        }
    }
}
