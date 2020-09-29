using System;

namespace Kw_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
           
            Console.WriteLine("Введіть число типу int");
            string x = Console.ReadLine();
            int a = Convert.ToInt32(x);
            
            Console.WriteLine("Введіть число типу double");
            string y= Console.ReadLine();
            double b = Convert.ToDouble(y);
            
            
            Console.WriteLine("Введіть число типу long");
            string z = Console.ReadLine();
            long c = Convert.ToInt64(z);
            
            
            Console.WriteLine($"a = {a},b = {b},c = {c}");

        }
    }
}
