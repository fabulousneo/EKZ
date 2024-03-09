using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите натуральное число N: ");
        string numberStr = Console.ReadLine();

        char[] digits = numberStr.ToCharArray();

        Array.Sort(digits);
        Array.Reverse(digits);

        string resultStr = new string(digits);

        Console.WriteLine($"Наибольшее число равно {resultStr}.");
    }
}