class Program
{
    static void Main(string[] args)
    {
        int[] array = { 4, 2, 7, 1, 9, 5 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        BubbleSort(array);

        Console.WriteLine("\nОтсортированный массив:");
        PrintArray(array);
    }
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}