using System;

class Program
{
    static void Main()
    {
        // Solicita o valor do boleto e a quantidade de dias em atraso
        Console.Write("Digite o valor do boleto: ");
        double valorBoleto = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade de dias em atraso: ");
        int diasAtraso = Convert.ToInt32(Console.ReadLine());

        // Calcula o novo valor com a taxa de 1,75% ao dia
        double taxaDiaria = 0.0175;
        double novoValor = CalcularNovoValor(valorBoleto, diasAtraso, taxaDiaria);

        // Exibe o resultado
        Console.WriteLine($"O novo valor do boleto com atraso é: R${novoValor:F2}");
    }

    // Função para calcular o novo valor
    static double CalcularNovoValor(double valorBoleto, int diasAtraso, double taxaDiaria)
    {
        double novoValor = valorBoleto * Math.Pow((1 + taxaDiaria), diasAtraso);
        return novoValor;
    }
}
