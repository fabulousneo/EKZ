using System;

class Program
{
    static void Main(string[] args)
    {     
        int[] array = { 3, 7, 2, 8, 6, 4, 9, 7 };    
        int count = 0;
      
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                count++;
            }
        }

        Console.WriteLine($"Количество элементов, больших двух своих соседей: {count}");
    }
}