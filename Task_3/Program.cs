using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int x = 0;
            double y = 0;
            long z = 0;

            while (true) {
                try
                {
                    Console.WriteLine("Введіть число типу int");
                    string a = Console.ReadLine();
                    int x1 = Convert.ToInt32(a);
                    x = x1;
                    break;
                }
                catch
                {
                    Console.WriteLine("Виникла помилка. Повторіть спробу");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введіть число типу double");
                    string b = Console.ReadLine();
                    double y1 = Convert.ToDouble(b);
                    y = y1;
                    break;
                }
                catch
                {
                    Console.WriteLine("Виникла помилка. Повторіть спробу");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введіть число типу long");
                    string c = Console.ReadLine();
                    long z1 = Convert.ToInt64(c);
                    z = z1;
                    break;
                }
                catch
                {
                    Console.WriteLine("Виникла помилка. Повторіть спробу");
                }
            }
            Console.WriteLine($"a = {x},b = {y},c = {z}");
        }
    }
}
