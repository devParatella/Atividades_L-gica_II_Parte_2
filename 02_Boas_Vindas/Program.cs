using System;

namespace BoasVindas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declara uma variável para armazenar o nome da pessoa
            string? nome;

            // Solicita o nome da pessoa ao usuário
            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();

            // Mostra uma mensagem de boas-vindas para a pessoa
            Console.WriteLine("Olá, {0}!", nome);
        }
    }
}