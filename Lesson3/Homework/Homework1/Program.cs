using System;
using StructureComplex;
using ClassComplex;
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.
namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            StrComplex a = new(3, 4);
            StrComplex b = new(5, 6);
            //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
            StrComplex difference = a.Subtract(b);
            Console.WriteLine(difference.ToString());
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
            ClComplex c = new(13, 14);
            ClComplex d = new(15, 16);
            ClComplex minus = c.Subtract(d);
            Console.WriteLine(minus.ToString());
            ClComplex mult = ClComplex.Multiply(c, d);
            Console.WriteLine(mult.ToString());
            //в) Добавить диалог с использованием switch демонстрирующий работу класса.
            c.Dialogue(d);
            ClComplex x = c.DialogueReturn(d);
            Console.WriteLine(x);
        }
    }
}
