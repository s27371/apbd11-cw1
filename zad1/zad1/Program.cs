internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        int[] numbers = { 1, 2, 4 };
        Console.WriteLine(FindAverage(numbers));
    }
    public static double FindAverage(int[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum/numbers.Length;

    }
}