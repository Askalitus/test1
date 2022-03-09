using System;
namespace lolita
{
    class mishen
    {
        static void Main()
        {
            //переменные
            int point = 0;
            Random rnd = new Random();
            //вводим участника и определяем мишень
            Console.Write("Введите номер участника: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 != 0)
            {
                //рандомим мишень для стрельбы в слепую
                int centr = rnd.Next(0, 10);
                //стреляем
                for (int i = 1; i <= 5; i++)
                {
                    //создаем помехи при стрельбе
                    double miss = rnd.NextDouble();

                    Console.WriteLine("Введите координаты {0} выстрела", i);
                    Console.WriteLine("x= ");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("y= ");
                    double y = double.Parse(Console.ReadLine());

                    x = x + miss;
                    y = y + miss;

                    if ((x <= centr + 1 && x >= centr - 1 && y <= centr + 1 && y >= centr - 1))
                    {
                        point = point + 10;
                        goto m;
                    }
                    if ((x >= centr + 1 && x <= centr + 2 && y >= centr + 1 && y <= centr + 2) || (x <= centr - 1 && x >= centr - 2 && y <= centr - 1 && y >= centr - 2))
                    {
                        point = point + 5;
                    }
                    //выводим очки
                    m:
                    Console.WriteLine("У вас {0} очков", point);
                }
            }

            else
            {
                //рандомим мишень для стрельбы в слепую
                int centr = rnd.Next(0, 10);
                //стреляем
                for (int i = 1; i <= 5; i++)
                {
                    //создаем помехи при стрельбе
                    double miss = rnd.NextDouble();

                    Console.WriteLine("Введите координаты {0} выстрела", i);
                    Console.WriteLine("x= ");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("y= ");
                    double y = double.Parse(Console.ReadLine());

                    x = x + miss;
                    y = y + miss;
                    
                    if ((x <= centr + 1 && x >= centr - 1 && y <= centr + 1 && y >= centr - 1))
                    {
                        point = point + 10;
                        goto m;
                    }
                    if ((x >= centr + 1 && x <= centr + 2 && y >= centr + 1 && y <= centr + 2) || (x <= centr - 1 && x >= centr - 2 && y <= centr - 1 && y >= centr - 2))
                    {
                        point = point + 5;
                        goto m;
                    }
                    if ((x >= centr + 2 && x <= centr + 3 && y >= centr + 2 && y <= centr + 3) || (x <= centr - 2 && x >= centr - 3 && y <= centr - 2 && y >= centr - 3))
                    {
                        point = point + 1;
                    }
                    //выводим очки
                    m:
                    Console.WriteLine("У вас {0} очков", point);
                }
            }
        }
    }
}
