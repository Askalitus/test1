using System;

namespace lolita
{
    class Goda
    {
        static void Main()
        {

            Console.Write("Введите год: ");

            int god = int.Parse(Console.ReadLine());

            Console.Write("В этом году: ");

            if (god % 100 == 0)
            {
                Console.Write("{0} Столетие", god / 100);

            }
            else
            {
                Console.Write("{0} Столетие", god / 100 + 1);
            }
        }
    }
}
