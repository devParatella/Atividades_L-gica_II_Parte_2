using System;

namespace ExibaMsgUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declara a variável que irá armazenar a mensagem digitada pelo usuário("string?" para não dar erro de variável não anulável)
            string? mensagem;

            // Solicita ao usuário que digite uma mensagem
            Console.WriteLine("Digite uma mensagem:");

            // Lê a mensagem digitada pelo usuário
            mensagem = Console.ReadLine();

            // Exibe a mensagem na tela. ({0} serve como um espaço reservado para o valor que queremos inserir posteriormente.)
            Console.WriteLine("A mensagem digitada é: {0}", mensagem);
        }
    }
}