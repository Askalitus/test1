using System;
namespace lolita
{
    class upr1
    {
        static void Main()
        {
            int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0) myArray[i] = 0;

                Console.WriteLine(myArray[i]);
            }

            int[] myArray2;

            Console.Write("n= ");

            int n = int.Parse(Console.ReadLine());

            myArray2 = new int[n];

            Length:
                    for (int i = 0; i < myArray2.Length ; i++)
                    {
                        Console.Write("a{0}= ",i);
                        myArray2[i] = int.Parse(Console.ReadLine());
                    }

            foreach (int x in myArray2) Console.Write("{0} ", x);
        }
    }
}
