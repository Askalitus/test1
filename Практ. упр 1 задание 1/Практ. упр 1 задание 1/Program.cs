using System;
namespace lolita
{
    class Ex1
    {
        static void Main()
        {
            Console.Write("х=");

            float x = float.Parse(Console.ReadLine());

            Console.Write("y=");

            float y = float.Parse(Console.ReadLine());

            if (x * x + y * y < 9 && y > 0)
            {
                Console.WriteLine("внутри");
            }

            else if (x * x + y * y > 9 || y < 0)
            {
                Console.WriteLine("вне");
            }

            else
            {
                Console.WriteLine("на границе");
            }
        }
    }
}