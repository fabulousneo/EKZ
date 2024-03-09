using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество чисел в последовательности: ");
        int n = int.Parse(Console.ReadLine());

        double[] sequence = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите {i + 1}-е число: ");
            sequence[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("Введенная последовательность: ");
        PrintSequence(sequence);
    }

    static void PrintSequence(double[] sequence)
    {
        foreach (double num in sequence)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}