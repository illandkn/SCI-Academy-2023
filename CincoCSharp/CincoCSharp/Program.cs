public class Program
{
    public static void Main()
    {
        string[,] studentsGrades = new string[3, 5];
        double[] averages = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Nome do {i + 1}º aluno: ");
            studentsGrades[i, 0] = Console.ReadLine();
            for (int j = 1; j < 5; j++)
            {
                Console.Write($"Nota {j} do {i + 1}º aluno: ");
                studentsGrades[i, j] = Console.ReadLine();
            }
            Console.WriteLine("");
        }

        for (int i = 0; i < 3; i++)
        {
            double sum = 0;
            for (int j = 1; j < 5; j++)
            {
                sum += double.Parse(studentsGrades[i, j]);
            }
            averages[i] = sum / 4;
        }

        Console.WriteLine("\nMédias dos alunos:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{studentsGrades[i, 0]}: {averages[i]:F2}");
        }

        double highestAverage = averages[0], lowerAverage = averages[0];
        string studentHighestAverage = studentsGrades[0, 0], studentLowerAverage = studentsGrades[0, 0];
        for (int i = 1; i < 3; i++)
        {
            if (averages[i] > highestAverage)
            {
                highestAverage = averages[i];
                studentHighestAverage = studentsGrades[i, 0];
            }
            if (averages[i] < lowerAverage)
            {
                lowerAverage = averages[i];
                studentLowerAverage = studentsGrades[i, 0];
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nAluno com a maior média: {studentHighestAverage} ({highestAverage:F2})");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Aluno com a menor média: {studentLowerAverage} ({lowerAverage:F2})");
        Console.ResetColor();
        Console.ReadKey();
    }
}
