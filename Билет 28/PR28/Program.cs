using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите коэффициенты квадратного уравнения");

        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Это не квадратное уравнение.");
        }
        else
        {
            double disc = b * b - 4 * a * c;

            if (disc > 0)
            {   
                double x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                double x2 = (-b - Math.Sqrt(disc)) / (2 * a);
                Console.WriteLine("Уравнение имеет два корня:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (disc == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Уравнение имеет один корень:");
                Console.WriteLine("x = " + x);
            }
            else
            {
                Console.WriteLine("Уравнение не имеет действительных корней.");
            }
        }
    }
}
