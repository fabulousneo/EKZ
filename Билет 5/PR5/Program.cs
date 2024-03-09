using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 10, 1, 5, 2, 6, 4, 12, 7 };

        int max = array[0];
        foreach (int num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }

        int sum = 0;
        foreach (int num in array)
        {
            if (num != max)
            {
                sum += num;
            }
        }

        Console.WriteLine($"Максимальное число: {max}. Сумма всех элементов: {sum}.");
    }
}
