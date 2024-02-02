using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe a largura da parede em metros:");
        double largura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a altura da parede em metros:");
        double altura = Convert.ToDouble(Console.ReadLine());

        double area = CalcularArea(largura, altura);
        double litrosDeTinta = CalcularLitrosDeTinta(area);

        Console.WriteLine($"Área a ser pintada: {area} metros quadrados");
        Console.WriteLine($"Quantidade de tinta necessária: {litrosDeTinta} litros");
    }

    static double CalcularArea(double largura, double altura)
    {
        return largura * altura;
    }

    static double CalcularLitrosDeTinta(double area)
    {
        // Cada litro de tinta pinta uma área de 2 metros quadrados
        return area / 2;
    }
}
