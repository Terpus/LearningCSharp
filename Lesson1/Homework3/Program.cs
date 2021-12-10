using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Терпинов Борис
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            Console.WriteLine("Введите координату x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            //а)
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками: {r:F2}");
            Console.ReadLine();
            //б)
            Console.WriteLine($"Расстояние между двумя точками, с использованием метода: {Distance(x1,y1,x2,y2):F2}");
            Console.ReadLine();
        }

        private static double Distance(int x1, int y1, int x2, int y2) /*Вычисление расстояния между точками в виде метода*/
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
