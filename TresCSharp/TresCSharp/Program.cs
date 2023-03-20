public class Program
{
    public static void Main()
    {
        string? student;
        double[] grades = new double[4];
        bool keep = true;

        while (keep)
        {
            Console.Write("Digite o nome do aluno (ou 'fim' para encerrar): ");
            student = Console.ReadLine();

            if (student == "fim")
            {
                keep = false;
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"Digite a {i + 1}ª nota: ");
                    grades[i] = Convert.ToDouble(Console.ReadLine());
                }

                double average = (grades[0] + grades[1] + grades[2] + grades[3]) / 4;

                Console.WriteLine($"\nAluno: {student}");
                Console.WriteLine($"Média: {average}");

                if (average > 6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reprovado");
                }
            }

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
