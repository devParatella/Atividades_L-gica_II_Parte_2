using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a idade em dias:");
        int idadeEmDias = Convert.ToInt32(Console.ReadLine());

        // Calcula anos, meses e dias
        int anos = idadeEmDias / 365;
        int meses = (idadeEmDias % 365) / 30;
        int dias = (idadeEmDias % 365) % 30;

        // Exibe o resultado
        Console.WriteLine($"Idade: {anos} anos, {meses} meses, {dias} dias.");
    }
}
