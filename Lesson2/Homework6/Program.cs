using System;
//*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            GoodNumbers();
            DateTime finish = DateTime.Now;
            Console.WriteLine(finish - start);

        }

        private static void GoodNumbers()
        {
            int counter = 0;
            for (int i = 111; i <= 1000000000; i++)
            {
                int sum=0;
                int digit;
                int n=i;
                do
                {
                    digit = n % 10;
                    n = n / 10;
                    sum += digit;
                } while (n!=0);
                if (i % sum == 0)
                {
                    counter++;
                }
                //Console.WriteLine(i);
                //Console.WriteLine(sum);
            }
            Console.WriteLine($"Найдено {counter} «хороших» чисел");
        }
    }
}
