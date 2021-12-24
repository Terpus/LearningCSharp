using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson4ClassLibrary
{
    public struct Account
    {
        //private string login;
        //private string password;
        private string[,] list;
        public Account(int row, int column = 2)
        {
            list = new string[row, column];
            for (int i = 0; i < list.GetLength(0); i++)
            {
                for (int j = 0; j < list.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                    {
                        list[i, j] = "name";
                    }
                    else list[i, j] = "password";
                }
            }
        }
        //public string Login
        //{
        //    get { return }
        //}
        public void ReadData(int i)
        {
            i--;
            Console.WriteLine($"{list[i, 0]} {list[i, 1]}");
        }
        public void GetData(string filename)
        {
            while (!File.Exists(filename))
            {
                Console.WriteLine($"Файл с путем {filename} не существует. Укажите другой путь к файлу.");
                filename = Console.ReadLine();
            }
            StreamReader sr = new(filename);
            int n = 0;
            do
            {
                sr.ReadLine();
                n++;
            } while (!sr.EndOfStream);
            //text = sr.ReadToEnd();
            //string[] file = text.Split("\r\n");
            //n = file.Length;
            list = new string[n, 2];
            sr.BaseStream.Position = 0;
            for (int i = 0; i < list.GetLength(0); i++)
            {
                n = 0;
                string[] line = sr.ReadLine().Split(" - ");
                for (int j = 0; j < list.GetLength(1); j++)
                {
                    list[i, j] = line[n];
                    n++;
                }
            }
            sr.Close();
        }
        public void GetData1(string filename) /*Этот метод, кажется, быстрее*/
        {
            while (!File.Exists(filename))
            {
                Console.WriteLine("Файл с данным путем не существует. Укажите другой путь к файлу.");
                filename = Console.ReadLine();
            }
            StreamReader sr = new(filename);
            string text;
            //do
            //{
            //    sr.ReadLine();
            //    n++;
            //} while (!sr.EndOfStream);
            text = sr.ReadToEnd();
            string[] file = text.Split("\r\n");
            int n = file.Length;
            list = new string[n, 2];
            sr.BaseStream.Position = 0;
            for (int i = 0; i < list.GetLength(0); i++)
            {
                n = 0;
                string[] line = sr.ReadLine().Split(" - ");
                for (int j = 0; j < list.GetLength(1); j++)
                {
                    list[i, j] = line[n];
                    n++;
                }
            }
            sr.Close();
        }
        public string SetName(int i, string name)
        {
            i--;
            return list[i, 0] = name;
        }
        public string SetPassword(int i, string password)
        {
            i--;
            return list[i, 1] = password;
        }
        public void SetData(int n, string name, string password)
        {
            n--;
            list[n, 0] = name;
            list[n, 1] = password;
        }
        public string this[int i, int j]
        {
            get
            {
                return list[i, j];
            }
            set => list[i, j] = value;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.GetLength(0); i++)
            {
                for (int j = 0; j < list.GetLength(1); j++)
                {
                    sb.Append($"{list[i, j]} ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
        public void Verification()
        {
            string name = null;
            string password = null;
            bool check = false;
            int attempt = 3;
            int i = 0;
            do
            {
                Console.WriteLine("Введите имя пользователя:");
                name = Console.ReadLine();
                for (i = 0; i < list.GetLength(0); i++)
                {
                    if (check = name.Equals(list[i, 0]))
                    {
                        break;
                    }
                }
                if (!check)
                {
                    attempt--;
                    Console.WriteLine($"Неверное имя пользователя. Осталось попыток: {attempt}");
                }
                if (attempt == 0)
                {
                    Console.WriteLine("У вас закончились попытки. Перезапустите программу.");
                    Console.ReadLine();
                    return;
                }
            } while (!check && attempt > 0);
            attempt = 3;
            do
            {
                if (attempt == 3) Console.WriteLine($"Здравствуйте, {name}! Ввведите пароль:");
                password = Console.ReadLine();
                check = password.Equals(list[i, 1]);
                if (!check)
                {
                    attempt--;
                    Console.WriteLine($"К сожалению, пароль неверен. Попробуйте еще раз. Осталось попыток: {attempt}");
                }
                if (attempt == 0)
                {
                    Console.WriteLine("У вас закончились попытки. Перезапустите программу.");
                    Console.ReadLine();
                    return;
                }
            } while (!check && attempt > 0);
            Console.WriteLine($"Добро пожаловать, {name}!");
        }
    }
}

