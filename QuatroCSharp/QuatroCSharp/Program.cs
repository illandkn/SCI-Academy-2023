public class Program
{
    public static void Main()
    {
        int[] vector = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"\nO valor na posição 3 é: {vector[2]}");
        Console.ReadKey();
    }
}
