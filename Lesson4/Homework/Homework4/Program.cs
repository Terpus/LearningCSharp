using System;
using System.IO;
using Lesson4ClassLibrary;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 4
            //Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.Создайте структуру Account, содержащую Login и Password.
            //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
            Account db = new();
            db.GetData(@"D:\Accounts.txt");
            db.SetName(1, "John");
            db.SetPassword(1, "12345");
            db.SetData(2, "Mark", "Williams");
            db.SetData(3, "Henry", "Ford");
            Console.WriteLine($"{db[0, 0]}");
            db.Print();
            db.Verification();
            #endregion
        }
    }
}