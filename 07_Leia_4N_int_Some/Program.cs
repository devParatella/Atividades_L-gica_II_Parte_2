using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[4]; // Array para armazenar os 4 números

        // Loop para ler os 4 números
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Digite o {i + 1}º número inteiro: ");
            if (int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                // Número válido
            }
            else
            {
                Console.WriteLine("Por favor, digite um número inteiro válido.");
                i--; // Decrementa o índice para repetir a leitura do mesmo número
            }
        }

        // Calcula o somatório
        int somatorio = 0;
        foreach (int numero in numeros)
        {
            somatorio += numero;
        }

        // Mostra o somatório
        Console.WriteLine($"O somatório dos números é: {somatorio}");
    }
}
