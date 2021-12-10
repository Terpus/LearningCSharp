using System;

namespace Homework6
{
    class Program
    {
        //Терпинов Борис
        //*Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
        private static int PromptInt(string text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }
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
        private static void Pause()
        {
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Pause();
        }
    }
}
