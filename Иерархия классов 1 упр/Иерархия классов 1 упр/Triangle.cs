using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Иерархия_классов_1_упр
{
    internal class Triangle
    {
        private int FirstSide;
        private int SecondSide;
        private int ThirdSide;

        public Triangle(int FirstSide, int SecondSide, int ThirdSide)
        {
            this.FirstSide = FirstSide;
            this.SecondSide = SecondSide;
            this.ThirdSide = ThirdSide;
        }

        public void Sides()
        {
            Console.WriteLine("\n 1 сторона: {0} \n 2 сторона: {1} \n 3 сторона: {2}", FirstSide, SecondSide, ThirdSide);
        }

        public void P()
        {
            Console.WriteLine("Периметр равен: {0}", FirstSide + SecondSide + ThirdSide);
        }

        public void S()
        {
            Console.WriteLine("Площадь равна: {0}", FirstSide * SecondSide * ThirdSide);
        }

        public void Proverka()
        {
            if (FirstSide + SecondSide <= ThirdSide || FirstSide + ThirdSide <= SecondSide || SecondSide + ThirdSide <= FirstSide)
            {
                Console.WriteLine("Такого треугольника не существует");
            }
            else
            {
                Console.WriteLine("Такой треугольник существует");
            }
        }
    }

}
