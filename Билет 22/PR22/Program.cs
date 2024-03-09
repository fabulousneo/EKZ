using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точки");

        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите x: ");
        double y = Convert.ToDouble(Console.ReadLine());

        int quarter;
        if (x > 0 && y > 0)
        {
            quarter = 1;
        }
        else if (x < 0 && y > 0)
        {
            quarter = 2;
        }
        else if (x < 0 && y < 0)
        {
            quarter = 3;
        }
        else if (x > 0 && y < 0)
        {
            quarter = 4;
        }
        else
        {
            Console.WriteLine("Точка находится на оси или в начале координат.");
            return;
        }

        double cosValue = Math.Cos(Math.Atan2(y, x));
        string sign;
        if (quarter == 1 || quarter == 4)
        {
            sign = cosValue >= 0 ? "положительной" : "отрицательной";
        }
        else
        {
            sign = cosValue <= 0 ? "положительной" : "отрицательной";
        }

        Console.WriteLine($"Знак косинуса в {quarter} четверти {sign} плоскости");
    }
}