using System;

class Program
{
    static void Main()
    {
        // Solicitar o nome do funcionário
        Console.Write("Digite o nome do funcionário: ");
        string nome = Console.ReadLine();

        // Solicitar o salário do funcionário
        Console.Write("Digite o salário do funcionário: ");
        // Usar decimal para representar o salário
        decimal salario = Convert.ToDecimal(Console.ReadLine());

        // Exibir mensagem com o nome e o salário do funcionário formatado como moeda
        Console.WriteLine("\nInformações do Funcionário:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Salário: {salario.ToString("C")}"); // Formatação como moeda

        Console.ReadLine(); // Apenas para manter a janela do console aberta
    }
}
