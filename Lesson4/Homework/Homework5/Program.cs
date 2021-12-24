using System;
using System.IO;
using Lesson4ClassLibrary;
//Терпинов Борис
//а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
//*б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
//**в) Обработать возможные исключительные ситуации при работе с файлами.
namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 5a
            //а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
            MyArray2D a = new(5, 1, 10);
            Homework5a(a);
            //*б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
            MyArray2D b = new(5, -100, 100);
            Homework5b(a, b);
            //**в) Обработать возможные исключительные ситуации при работе с файлами.
            MyArray2D d = new(@"B:\array_notexisting.txt");
            #endregion
        }


        private static void Homework5a(MyArray2D a)
        {
            string indexOfMax;
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Average);
            Console.WriteLine(a.Sum());
            Console.WriteLine(a.SumOfMoreThan(a[1, 1]));
            Console.WriteLine(a.Min);
            Console.WriteLine(a.Max);
            a.MaxElIndex(out indexOfMax);
            Console.WriteLine(indexOfMax);
            MyArray2D fromFile = new(@"B:\array.txt");
            Console.WriteLine(fromFile.ToString());
        }
        private static void Homework5b(MyArray2D a, MyArray2D b)
        {
            Console.WriteLine(a.ToString());
            a.WriteToFile(@"B:\array2.txt");
            MyArray2D c = new(@"B:\array2.txt");
            Console.WriteLine(b.ToString());
        }
    }
}
