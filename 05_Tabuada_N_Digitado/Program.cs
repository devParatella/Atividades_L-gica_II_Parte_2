using System;

class Program
{
    static void Main()
    {
        // Solicita o nome da disciplina
        Console.Write("Digite o nome da disciplina: ");
        string disciplina = Console.ReadLine();

        // Solicita o nome do aluno
        Console.Write("Digite o nome do aluno: ");
        string aluno = Console.ReadLine();

        // Inicializa a variável para armazenar a soma das notas
        double somaNotas = 0;

        // Loop para obter as cinco notas do aluno
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite a nota {i}: ");
            // Converte a entrada do usuário para um número
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                // Adiciona a nota à soma
                somaNotas += nota;
            }
            else
            {
                Console.WriteLine("Por favor, insira uma nota válida.");
                // Decrementa o índice para repetir a mesma iteração
                i--;
            }
        }

        // Calcula a média das notas
        double media = somaNotas / 5;

        // Exibe a média na tela
        Console.WriteLine($"A média do aluno {aluno} na disciplina {disciplina} é: {media}");

        // Aguarda o usuário pressionar Enter antes de fechar o console
        Console.ReadLine();
    }
}
