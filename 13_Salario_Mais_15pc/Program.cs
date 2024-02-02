using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira o salário atual
        Console.Write("Digite o salário atual do funcionário: ");
        
        // Lê o salário inserido pelo usuário
        double salarioAtual = Convert.ToDouble(Console.ReadLine());

        // Calcula o novo salário com 15% de aumento
        double novoSalario = salarioAtual * 1.15;

        // Exibe o novo salário
        Console.WriteLine($"O novo salário com 15% de aumento é: {novoSalario:C}");

        // Aguarda o usuário pressionar Enter para fechar o console
        Console.ReadLine();
    }
}
