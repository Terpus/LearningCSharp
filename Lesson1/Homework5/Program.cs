using System;

namespace Homework5
{
    class Program
    {
        private static string PromptText(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
        private static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }
        static void Main(string[] args)
        {
            //Терпинов Борис
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) *Сделать задание, только вывод организовать в центре экрана.
            //в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            string fname = PromptText("Введите ваше имя");
            string lname = PromptText("Введите вашу фамилию");
            string city = PromptText("Введите ваш город");
            Console.WriteLine($"Вас зовут {fname} {lname}, вы проживаете в городе {city}");
            //б) *Сделать задание, только вывод организовать в центре экрана.
            Console.SetCursorPosition(40, 13);
            Console.WriteLine($"Вас зовут {fname} {lname}, вы проживаете в городе {city}");
            //в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
            Print($"Вас зовут {fname} {lname}, вы проживаете в городе {city}", 40, 12);
        }
    }
}
