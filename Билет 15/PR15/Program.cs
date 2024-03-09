using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 100 || number > 999)
        {
            Console.WriteLine("Введено неверное число. Пожалуйста, введите трехзначное число.");
            return;
        }

        int numOne = number / 100;         
        int numTwo = (number / 10) % 10;    
        int numThree = number % 10;           

        int result = numOne * numTwo * numThree;

        Console.WriteLine($"Произведение цифр трехзначного числа: {result}");
    }
}
