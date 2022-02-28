using System;
namespace lolita
{
    class xyz
    { 
        static void Main()
        {
            Console.Write("Введите х: ");

            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите y: ");

            int y = int.Parse(Console.ReadLine());

            Console.Write("Введите z: ");

            int z = int.Parse(Console.ReadLine());

            if (x % 2 == 0 || y % 2 == 0 || z % 2 == 0)
            {
                int max = x;

                if (y > x)

                {
                    max = y;

                    if (z > y)
                    {
                        max = z;
                    }
                }

                if (z > x)
                {
                    max = z;

                    if (y > z)
                    {
                        max = y;
                    }
                }

                Console.WriteLine("Максимальное число: {0}", max);


            }

            else
            {
                int min = x;

                if (y < x)

                {
                    min = y;

                    if (z < y)
                    {
                        min = z;
                    }
                }

                if (z < x)
                {
                    min = z;

                    if (y < z)
                    {
                        min = y;
                    }
                }

                Console.WriteLine("Минимальное число: {0}", min);
            }
        }
    }

}
