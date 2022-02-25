class HelloUser
{
    static void Main()
    {
        Console.WriteLine("Калькулятор");

        Console.WriteLine("Введие действие, которое хотите выполнить (сложить, умножить, вычесть, разделить");

        string d = Console.ReadLine();

        Console.WriteLine("Введите первое число");

        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число");

        double b = double.Parse(Console.ReadLine());

        if (d == "сложить")
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        if (d == "умножить")
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }

        if (d == "вычесть")
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }

        if (d == "разделить")
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
    }
}
