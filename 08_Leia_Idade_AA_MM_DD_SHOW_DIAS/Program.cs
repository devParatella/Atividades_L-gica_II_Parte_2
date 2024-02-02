using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a idade em anos:");
        int anos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a idade em meses:");
        int meses = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a idade em dias:");
        int dias = Convert.ToInt32(Console.ReadLine());

        // Calcula a idade em dias
        int idadeEmDias = CalcularIdadeEmDias(anos, meses, dias);

        // Exibe a idade em dias
        Console.WriteLine($"A idade em dias é: {idadeEmDias} dias");
    }

    static int CalcularIdadeEmDias(int anos, int meses, int dias)
    {
        // Assume que um ano tem 365 dias e um mês tem 30 dias (aproximadamente)
        return (anos * 365) + (meses * 30) + dias;
    }
}
