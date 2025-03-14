internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        int[] n = { 1, 2, 4 };
        Console.WriteLine(FindAverage(n));
        Console.WriteLine(FindMax(n));

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
    public static int FindMax(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
           
        }
        return max;

    }



}