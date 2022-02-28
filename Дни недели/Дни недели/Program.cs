using System;
namespace lolita
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите день в году: ");

            int den = int.Parse(Console.ReadLine());

            Console.Write("День недели этого дня: ");

            switch (den % 7)
            {
                case 0: Console.Write("Пятница");
                    break;
                case 1:
                    Console.Write("Суббота");
                    break;
                case 2:
                    Console.Write("Воскресенье");
                    break;
                case 3:
                    Console.Write("Понедельник");
                    break;
                case 4:
                    Console.Write("Вторник");
                    break;
                case 5:
                    Console.Write("Среда");
                    break;
                case 6:
                    Console.Write("Четверг");
                    break;
            }
        }
    }
}
