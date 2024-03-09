namespace CSharpCode
{
    class Program
    {
        static int AgeCalc(int BYear)
        {
            if (BYear < 0)
                throw new Exception("ОШИБКА: отрицательное значение года рождения!!!");
            DateTime dt = DateTime.Now;
            if (BYear > dt.Year)
                throw new Exception("ОШИБКА: Значение года рождения больше значения текущего го-да!!!");
            return dt.Year - BYear;
        }

        static void Main(string[] args)
        {

            Console.Write("Введите свой год рождения: ");

            int BYear = int.Parse(Console.ReadLine());
            int Page = 0;

            try
            {
                Page = AgeCalc(BYear);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
            }

            Console.WriteLine(String.Concat(Enumerable.Repeat("-", 30)));

            Console.WriteLine("Год рождения: " + BYear + "\nВозраст: " + Page);
            Console.ReadKey();
        }
    }
}