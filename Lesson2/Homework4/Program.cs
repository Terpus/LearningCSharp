using System;
using MyMethods;
//4.Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
namespace Homework4
{
    class Program
    {
        static string inputL, inputP;

        private static bool CheckPassword(string login = "root", string password = "GeekBrains")
        {
            int attempt = 3;
            bool checkRes = false;
            do
            {
                inputL = MyMethods.Program.InputText("Введите логин");
                if (inputL == login)
                {
                    inputP = MyMethods.Program.InputText("Введите пароль");
                    if (inputP == password)
                    {
                        checkRes = true;
                    }
                    else
                    {
                        attempt--;
                        Console.WriteLine($"Неправильный пароль. Попробуйте еще раз. Осталось попыток: {attempt}");
                    }
                }
                else
                {
                    attempt--;
                    Console.WriteLine($"Пользователя с таким именем не существует. Попробуйте еще раз. Осталось попыток: {attempt}");
                }
            } while (checkRes == false && attempt != 0);
            return checkRes;
        }
        static void Main(string[] args)
        {
            if (CheckPassword("user", "password"))
            {
                Console.WriteLine("Добро пожаловать!");
            }
            else Console.WriteLine("В доступе отказано.");
        }
    }
}
