using System;

namespace MyStringHelpers
{
    public class StringHelper
    {
        private string originalString;

        
        public StringHelper(string inputString)
        {
            originalString = inputString;
        }

        
        public string ReverseString()
        {
            char[] charArray = originalString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            string userInput = Console.ReadLine();

            
            StringHelper helper = new StringHelper(userInput);

            
            string reversedString = helper.ReverseString();
            Console.WriteLine($"Реверсированная строка: {reversedString}");
        }
    }
}
