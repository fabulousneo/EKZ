using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        List<double> minNum = new List<double>();

        double[] array = new double[20]; 
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 10);
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        double minPositive = double.MaxValue;
        foreach (double num in array)
        {
            if (num > 0 && num < minPositive)
            {
                minPositive = num;
                minNum.Clear();
                minNum.Add(num);
            }
            else if (num > 0 && num == minPositive)
            {
                minNum.Add(num);
            }
        }

        minNum = minNum.Distinct().ToList();

        Console.WriteLine("\nМинимальные положительные элементы:");
        foreach (double num in minNum)
        {
            Console.WriteLine(num);
        }

        Console.ReadKey();
    }

    static void PrintArray(double[] array)
    {
        foreach (double num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}