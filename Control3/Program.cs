using System;

namespace MyExtensions
{
    public static class IntExtensions
    {
        public static int Increment(this int number)
        {
            return number + 1;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int userInput;
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                int incrementedNumber = userInput.Increment();
                Console.WriteLine($"Исходное число: {userInput}");
                Console.WriteLine($"Инкрементированное число: {incrementedNumber}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }
    }
}


