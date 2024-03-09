using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите количество членов K: ");
        int K = Convert.ToInt32(Console.ReadLine());

        double sum = 0;
        int n;

        for (n = 1; n <= K; n++)
        {
            sum += 1.0 / n;

            if (sum > A)
            {
                break;
            }
        }

        if (n > K)
        {
            Console.WriteLine("Среди первых {0} членов последовательности нет числа больше {1}.", K, A);
        }
        else
        {
            Console.WriteLine("Первый член последовательности, который больше {0}: {1}.", A, sum);
        }

        Console.ReadKey();
    }
}