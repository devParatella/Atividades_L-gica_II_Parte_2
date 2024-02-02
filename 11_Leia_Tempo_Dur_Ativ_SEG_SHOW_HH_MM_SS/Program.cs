using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira o tempo em segundos
        Console.Write("Digite o tempo em segundos: ");
        int tempoTotalSegundos = int.Parse(Console.ReadLine());

        // Calcula as horas, minutos e segundos
        int horas = tempoTotalSegundos / 3600;
        int minutos = (tempoTotalSegundos % 3600) / 60;
        int segundos = tempoTotalSegundos % 60;

        // Exibe o resultado
        Console.WriteLine($"Tempo total: {horas} horas, {minutos} minutos, {segundos} segundos");
    }
}
