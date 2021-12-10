using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Терпинов Борис
            //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.
            Console.WriteLine("Добро пожаловать в программу Анкета! Далее вам будет задано несколько вопросов.\nКак вас зовут?");
            string fname = Console.ReadLine();
            Console.WriteLine("Какая у вас фамилия?");
            string lname = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой у вас рост? (в сантиметрах)");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько вы весите?");
            int weight = Convert.ToInt32(Console.ReadLine());

            //Вывод, используя склеивание
            Console.WriteLine("Ваши данные:\n" + "Фамилия: " + lname + " Имя: " + fname +  " Возраст: " + age + " Рост: " + height + " см" + " Вес: " + weight + " кг");
            Console.ReadLine();
            //Форматированный вывод
            Console.WriteLine("Ваши данные:\nФамилия: {0} Имя: {1} Возраст: {2} Рост: {3} см Вес: {4} кг", lname, fname, age, height, weight);
            Console.ReadLine();
            //Вывод с интерполяцией строк
            Console.WriteLine($"Ваши данные:\nФамилия: {lname} Имя: {fname} Возраст: {age} Рост: {height} см Вес: {weight} кг");
            Console.ReadLine();
        }
    }
}
