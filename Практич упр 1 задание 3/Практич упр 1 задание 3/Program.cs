using System;
namespace lolita
{
    class Ex3
    {
        static void Main()
        {
            Console.Write("Введите год: ");

            int god = int.Parse(Console.ReadLine());

            if (god % 4 == 0 && god % 100 != 0 || god % 400 == 0)
            {
                Console.WriteLine("Этот год високосный");
            }

            else
            {
                Console.WriteLine("Этот год не високосный");
            }
        }
    }
}
