using System;
namespace lolita
{
    class login
    {
        static void Main()
        {
            Console.WriteLine("Введите логин");

            string log = Console.ReadLine();

            if (log == "Админ")
            {
                Console.WriteLine("Введите пароль");
            }

            else
            {
                Console.WriteLine("Я вас не знаю");
            }
        }
    }
}
