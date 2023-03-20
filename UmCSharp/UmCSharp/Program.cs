public class Program
{
    public static void Main()
    {
        int[] numbers = new int[5];
        double sum = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            sum += numbers[i];
        }

        Console.WriteLine("\nNúmeros pares:");
        for (int i = 0; i < 5; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        Console.WriteLine("\nNúmeros ímpares:");
        for (int i = 0; i < 5; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        Console.WriteLine($"\nMédia total: {sum / 5}");
        Console.ReadKey();
    }
}