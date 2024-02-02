using System;

class Dias_Trabalhados
{
    static void Main()
    {
        // Solicitar ao usuário o número de dias trabalhados
        Console.Write("Digite o número de dias trabalhados no mês: ");

        // Variável para armazenar o número de dias trabalhados
        double diasTrabalhados;

        // Loop para garantir que o valor inserido seja válido
        while (!double.TryParse(Console.ReadLine(), out diasTrabalhados))
        {
            Console.WriteLine("Por favor, digite um valor válido.");
            Console.Write("Digite o número de dias trabalhados no mês: ");
        }

        // Definir o salário por hora e as horas trabalhadas por dia
        double salarioPorHora = 75.00;
        int horasPorDia = 8;

        // Calcular o salário total
        double salarioTotal = diasTrabalhados * horasPorDia * salarioPorHora;

        // Exibir o salário total formatado como moeda
        Console.WriteLine($"O salário total do funcionário é: {salarioTotal:C}");
    }
}
