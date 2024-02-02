using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário para inserir os valores de a, b e c
        Console.Write("Digite o valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor de c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Calcula o valor de Delta
        double delta = Math.Pow(b, 2) - (4 * a * c);

        // Exibe o valor de Delta
        Console.WriteLine($"O valor de Delta (Δ) é: {delta}");

        // Aguarda o usuário pressionar Enter antes de fechar o console
        Console.ReadLine();
    }
}
