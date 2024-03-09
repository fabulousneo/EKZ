using System;

public class Program
{
    public static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);
            QuickSort(arr, left, pivot - 1);
            QuickSort(arr, pivot + 1, right);
        }
    }

    public static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                Swap(ref arr[i], ref arr[j]);
            }
        }
        Swap(ref arr[i + 1], ref arr[right]);
        return i + 1;
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void Main()
    {
        int size = 10;
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = new Random().Next(100);
        }
        Console.WriteLine("Исходный массив");
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i] + " ");
        }

        QuickSort(arr, 0, size - 1);
        Console.WriteLine("\nОтсортированный массив");
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}