using System;
namespace lolita
{
    class Ex1
    {
        static void Main()
        {
            double y;

            Console.Write("n= ");

            int n = int.Parse(Console.ReadLine());

            Console.Write("\nwhile: \t\t");

            int i = 1;

            while (i <= n)
            {
                Console.Write(" " + i);
                i += 2;
            }

            Console.Write("\ndo while: \t");

            i = 1;

            do
            {
                Console.Write(" " + i);

                i += 2;
            }
            while (i <= n);

            Console.Write("\nFor: \t\t");
            for (i = 1; i<=n; i+=2)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Введите границу х1");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите границу х2");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Значения функции");
            double x = x1;

            do
            {
                y = Math.Sin(x);
                Console.WriteLine("x={0}  y={1}", x, y);
                x = x + 0.01;
            }
            while (x <= x2);
            return;
        }
    }
}
