using System;
using MyMethods;
//5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
namespace Homework5
{
    class Program
    {
        static float h, m, bmi;
        static void Main(string[] args)
        {
            h = MyMethods.Program.InputInt("Введите рост в сантиметрах.");
            m = MyMethods.Program.InputInt("Введите массу тела.");
            float bmi = BMI(h, m);
        }

        private static float BMI(float h, float m)
        {
            string msg = null;
            float normal_m, diff_m;
            h /= 100;
            float bmi = m / (h * h);
            Console.WriteLine($"Индекс массы тела равен {Math.Round(bmi, 2)}");
            switch (bmi)
            {
                case <= 16:
                    msg = "Выраженный дефицит массы тела";
                    break;
                case <= 18.5f:
                    msg = "Недостаточная (дефицит) масса тела";
                    break;
                case <= 25:
                    msg = "Норма";
                    break;
                case <= 30:
                    msg = "Избыточная масса тела (предожирение)";
                    break;
                case <= 35:
                    msg = "Ожирение 1 степени";
                    break;
                case <= 40:
                    msg = "Ожирение 2 степени";
                    break;
                case > 40:
                    msg = "Ожирение 3 степени";
                    break;
                default:
                    msg = "Что-то пошло не так";
                    break;
            }
            Console.WriteLine(msg);
            switch (bmi)
            //* Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса
            {
                case < 18.5f:
                    normal_m = 18.5f * h * h;
                    diff_m = normal_m - m;
                    msg = $"Необходимо набрать {Math.Round(diff_m, 1)} кг для достижения нормальной массы тела";
                    break;
                case > 25:
                    normal_m = 25 * h * h;
                    diff_m = m - normal_m;
                    msg = $"Необходимо сбросить {Math.Round(diff_m, 1)} кг для достижения нормальной массы тела";
                    break;
                default:
                    msg = null;
                    break;
            }
            Console.WriteLine(msg);
            return bmi;
        }
    }
}
