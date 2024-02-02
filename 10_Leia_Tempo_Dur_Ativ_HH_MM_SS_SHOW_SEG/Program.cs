using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite as horas: ");
        int horas = int.Parse(Console.ReadLine());

        Console.Write("Digite os minutos: ");
        int minutos = int.Parse(Console.ReadLine());

        Console.Write("Digite os segundos: ");
        int segundos = int.Parse(Console.ReadLine());

        // Converte o tempo para segundos
        int totalSegundos = ConverteParaSegundos(horas, minutos, segundos);

        Console.WriteLine($"O tempo total em segundos é: {totalSegundos} segundos.");
    }

    static int ConverteParaSegundos(int horas, int minutos, int segundos)
    {
        // Calcula o total de segundos
        return horas * 3600 + minutos * 60 + segundos;
    }
}
