using System;
namespace lolita
{
    class Ex1
    {
        static void Main()
        {
            Console.Write("n= ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nwhile: \t\t");

            int i = 1;

            while (i <= n)
            {
                Console.Write(" " + i);
                i += 2;
            }

            Console.WriteLine("\ndo while: \t");

            i = 1;

            do
            {
                Console.Write(" " + i);

                i += 2;
            }
            while (i <= n);


        }
    }
}
