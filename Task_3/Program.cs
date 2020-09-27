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
                    Console.WriteLine();
                    string a = Console.ReadLine();
                    int x = Convert.ToInt32(a);
                    break;
                }
                catch
                {
                    Console.WriteLine("gjhgj");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    string b = Console.ReadLine();
                    double y = Convert.ToDouble(b);
                    break;
                }
                catch
                {
                    Console.WriteLine("gjhgj");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    string c = Console.ReadLine();
                    long z = Convert.ToInt64(c);
                    break;
                }
                catch
                {
                    Console.WriteLine("gjhgj");
                }
            }
            Console.WriteLine($"a = {x},b = {y},c = {z}");
        }
    }
}
