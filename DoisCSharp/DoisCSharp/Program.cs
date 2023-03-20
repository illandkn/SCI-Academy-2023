public class Program
{
    public static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int bigger = numbers[0];
        int smaller = numbers[0];
        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] > bigger)
            {
                bigger = numbers[i];
            }
            if (numbers[i] < smaller)
            {
                smaller = numbers[i];
            }
        }

        Console.WriteLine("\nO maior número é: " + bigger);
        Console.WriteLine("O menor número é: " + smaller);
        Console.ReadKey();
    }
}