namespace TriangleType
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Нажмите <Q> для выхода из программы или <Enter> для продолжения");

            while (Console.ReadKey().Key != ConsoleKey.Q)
            {
                try
                {

                    Console.WriteLine("Введите длины сторон треугольника:");
                    Console.Write("A = ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("B = ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("C = ");
                    c = double.Parse(Console.ReadLine());

                    if (a + b > c & b + c > a & a + c > b)
                    {
                        if (a == b && b == c) { Console.WriteLine("Равносторонний треугольник"); }

                        else if (a == b || b == c || c == a) { Console.WriteLine("Равнобедренный треугольник"); }

                        else if (c * c == a * a + b * b) { Console.WriteLine("Прямоугольный треугольник"); }

                        else { Console.WriteLine("Разносторонний треугольник"); }
                    }

                    else { Console.WriteLine("Такого треугольника не существует!"); }
                }
                catch
                {
                    Console.WriteLine(String.Concat(Enumerable.Repeat("-", 30)));

                    Console.WriteLine("Неверно введены данные\nПопробуйте снова!\n");
                }

                Console.WriteLine("Нажмите <Q> для выхода из программы или <Enter> для продолжения");
            }
        }
    }
}






