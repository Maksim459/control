internal class Program
{
    private static void Main(string[] args)
    {
        int[,] nums2 = { { 1, 2, 2, 4 }, { 3, 3, 7, 7 } };
        Console.WriteLine("значения массива");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine($" {nums2[i, j]}");
            }
        }
    }
}