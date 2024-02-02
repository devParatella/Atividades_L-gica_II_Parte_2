using System;

class Program
{
    static void Main()
    {
        // Taxas de conversão
        double taxaDolar = 4.92;
        double taxaLibra = 6.24;
        double taxaEuro = 5.33;

        // Solicitar o valor em reais
        Console.Write("Digite o valor em reais (R$): ");
        double valorEmReais = Convert.ToDouble(Console.ReadLine());

        // Calcular os valores nas outras moedas
        double valorEmDolar = valorEmReais / taxaDolar;
        double valorEmLibra = valorEmReais / taxaLibra;
        double valorEmEuro = valorEmReais / taxaEuro;

        // Exibir os resultados
        Console.WriteLine($"Valor em Dólares: ${valorEmDolar:F2}");
        Console.WriteLine($"Valor em Libras: £{valorEmLibra:F2}");
        Console.WriteLine($"Valor em Euros: €{valorEmEuro:F2}");
    }
}
