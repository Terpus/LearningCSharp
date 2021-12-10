using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Терпинов Борис
            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            Console.WriteLine("Введите вес");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите рост в метрах с запятой вместо точки");
            double h = Convert.ToDouble(Console.ReadLine());
            double i = m / (h * h);
            Console.WriteLine($"Индекс массы тела равен: {i:F2}");
            Console.ReadLine();
        }
    }
}
