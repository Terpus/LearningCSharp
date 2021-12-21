using System;

namespace MyMethods
{
    public class Program
    {
        public static int InputInt(string text)
        {
            Console.WriteLine(text);
            string input = Console.ReadLine();
            bool isNumber;
            isNumber = int.TryParse(input, out int result);
            if (!isNumber)
            {
                do
                {
                    Console.WriteLine("Повторите ввод, возможно вы ввели не число.");
                    input = Console.ReadLine();
                    isNumber = int.TryParse(input, out result);
                }
                while (!isNumber);
            }
            return result;
        }
        public static string InputText(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
        public static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }
        public static void Pause()
        {
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
        }
        //      #region Stopwatch
        //      DateTime start = DateTime.Now;
        //      //Сюда вставляем код, время выполнения которого необходимо измерить.
        //      DateTime finish = DateTime.Now; 
        ///*Console.WriteLine(finish-start);*/
        //      #endregion
        static void Main(string[] args)
        {
        }
    }
}
