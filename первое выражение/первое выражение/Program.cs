using System;
namespace lolita
{
    class lll
    {
        static void Main()
        {

            Console.WriteLine("Нахождение значения выражения c = ((b+z) * (a-b)) / x");

            Console.WriteLine("Введите b");

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите a");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите z");

            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите x");

            int x = int.Parse(Console.ReadLine());

            int c = ((b + z) * (a - b)) / x;

            Console.WriteLine("C= {0}", c);
        }
    }
}
