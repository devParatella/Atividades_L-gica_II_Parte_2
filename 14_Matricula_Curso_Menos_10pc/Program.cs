using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário que insira o valor da matrícula
        Console.Write("Digite o valor da matrícula do curso: ");
        
        // Ler o valor da matrícula como uma string
        string input = Console.ReadLine();
        
        // Converter a string para um tipo numérico (double)
        if (double.TryParse(input, out double valorMatricula))
        {
            // Calcular o novo valor com desconto de 10%
            double novoValor = CalcularNovoValorComDesconto(valorMatricula, 0.1);

            // Exibir o novo valor com desconto
            Console.WriteLine($"O novo valor da matrícula com 10% de desconto é: {novoValor:C}");
        }
        else
        {
            // Se a conversão falhar, exibir uma mensagem de erro
            Console.WriteLine("Por favor, insira um valor válido.");
        }
    }

    // Função para calcular o novo valor com desconto
    static double CalcularNovoValorComDesconto(double valorOriginal, double percentualDesconto)
    {
        return valorOriginal - (valorOriginal * percentualDesconto);
    }
}
