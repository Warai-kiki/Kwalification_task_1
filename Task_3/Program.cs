using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            while (true) {
                try
                {
                    Console.WriteLine("Введіть число типу int");
                    string a = Console.ReadLine();
                    int x = Convert.ToInt32(a);
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
                    double y = Convert.ToDouble(b);
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
                    long z = Convert.ToInt64(c);
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
