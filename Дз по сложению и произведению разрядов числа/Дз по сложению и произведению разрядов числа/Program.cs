using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_по_сложению_и_произведению_разрядов_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");

            int n = int.Parse(Console.ReadLine());

            double x = n % 10;

            double y = n / 10 % 10;

            double z = n / 100;

            Console.WriteLine("Сотни {0} Десятки {1} Единицы {2}", z, y, x);

            Console.WriteLine("Сложение: {0}", x + y + z);

            Console.WriteLine("Произведение: {0}", x * y * z);
        }
    }
}
