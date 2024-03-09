using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        string numberStr = Console.ReadLine();      
        char[] nums = numberStr.ToCharArray();

        Array.Sort(nums);
    
        if (nums[0] == '0')
        {         
            int i = 1;
            while (i < nums.Length && nums[i] == '0')
            {
                i++;
            }
    
            if (i < nums.Length)
            {
                char temp = nums[0];
                nums[0] = nums[i];
                nums[i] = temp;
            }
        }
  
        string resultStr = new string(nums);

        Console.WriteLine($"Наименьшее число, образованное перестановкой цифр числа: {resultStr}");
    }
}