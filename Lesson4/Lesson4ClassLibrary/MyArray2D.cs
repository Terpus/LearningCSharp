using System.Text;
namespace Lesson4ClassLibrary
{
    public class MyArray2D
    {
        //private int count = 0;

        private int elements = 0;

        private int[,] a;

        public int this[int i, int j]
        {
            get
            {
                return a[i, j];
            }
            set
            {
                a[i, j] = value;
            }
        }

        public int Min
        {
            get
            {
                int min = a[0, 0];
                int[,] array = a;
                foreach (int item in array)
                {
                    if (min > item)
                    {
                        min = item;
                    }
                }
                return min;
            }
        }

        public int Max
        {
            get
            {
                int max = a[0, 0];
                int[,] array = a;
                foreach (int item in array)
                {
                    if (max < item)
                    {
                        max = item;
                    }
                }
                return max;
            }
        }

        public int CountPositive
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > 0)
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
        }

        public double Average
        {
            get
            {
                double sum = Sum();
                return sum / (double)(a.GetLength(0) * a.GetLength(1));
            }
        }

        public MyArray2D()
        {
        }

        public MyArray2D(int n, int el = 0)
        {
            a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = el;
                }
            }
        }

        public MyArray2D(int n = 0, int min = 1, int max = 100)
        {
            Random rnd = new Random();
            a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(min, max);
                }
            }
        }

        public MyArray2D(string filename)
        {
            while (!File.Exists(filename))
            {
                Console.WriteLine($"Файл с путем {filename} не существует. Укажите другой путь к файлу.");
                filename = Console.ReadLine();
            }
            StreamReader sr = new StreamReader(filename);
            try
            {
                bool flag = true;
                do
                {
                    flag = int.TryParse(sr.ReadLine(), out elements);
                } while (!flag);
                a = new int[elements, elements];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    string text = sr.ReadLine();
                    string[] bits = text.Split(' ');
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        int.TryParse(bits[j], out a[i, j]);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw;
            }
            sr.Close();
        }

        public void WriteToFile(string filename)
        {
            elements = a.GetLength(0);
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(elements);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j == a.GetLength(1) - 1)
                    {
                        sw.Write($"{a[i, j]}");
                    }
                    else
                        sw.Write($"{a[i, j]} ");
                }
                sw.WriteLine();
            }
            sw.Close();
        }

        public int Sum()
        {
            int sum = 0;
            int[,] array = a;
            foreach (int item in array)
            {
                sum += item;
            }
            return sum;
        }

        public int SumOfMoreThan(int x)
        {
            int sum = 0;
            int[,] array = a;
            foreach (int item in array)
            {
                if (x < item)
                {
                    sum += item;
                }
            }
            return sum;
        }

        public void MaxElIndex(out string index)
        {
            index = "";
            int max = Max;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == max)
                    {
                        index += $"{i},{j} ";
                    }
                }
            }
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //string s = "";
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sb.Append($"{a[i, j]} ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }

}