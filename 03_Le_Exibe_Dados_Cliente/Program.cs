using System;

class Le_Exibe_Dados_Cliente
{
    static void Main()
    {
        // Declaração das variáveis do cliente
        string nomeDoCliente;
        string sobrenomeDoCliente;
        string cpfDoCliente;
        char sexoDoCliente;
        DateTime dataDeNascimentoDoCliente;
        string enderecoDoCliente;
        string telefoneDoCliente;

        // Método auxiliar para obter uma entrada não vazia do usuário
        string ObterEntradaNaoVazia(string mensagem)
        {
            string? entrada;
            do
            {
                Console.WriteLine(mensagem);
                entrada = Console.ReadLine()?.Trim(); // Tratamento de possível valor nulo
            } while (string.IsNullOrWhiteSpace(entrada));

            return entrada;
        }

        // Método auxiliar para obter uma data de nascimento válida do usuário
        DateTime ObterDataNascimentoValida()
        {
            DateTime dataNascimento;
            while (true)
            {
                Console.WriteLine("Digite a data de nascimento do cliente (dd/MM/yyyy):");
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascimento))
                {
                    return dataNascimento;
                }

                Console.WriteLine("Formato de data inválido. Tente novamente.");
            }
        }

        // Leitura dos dados do cliente do usuário

        // Nome do cliente
        nomeDoCliente = ObterEntradaNaoVazia("Digite o nome do cliente:");

        // Sobrenome do cliente
        sobrenomeDoCliente = ObterEntradaNaoVazia("Digite o sobrenome do cliente:");

        // CPF do cliente
        do
        {
            cpfDoCliente = ObterEntradaNaoVazia("Digite o CPF do cliente:");
        } while (cpfDoCliente.Length != 11 || !cpfDoCliente.All(char.IsDigit));

        // Sexo do cliente
        do
        {
            Console.WriteLine("Digite o sexo do cliente (M ou F):");
        } while (!char.TryParse(Console.ReadLine(), out sexoDoCliente) || (sexoDoCliente != 'M' && sexoDoCliente != 'F'));

        // Data de nascimento do cliente
        dataDeNascimentoDoCliente = ObterDataNascimentoValida();

        // Validação da data de nascimento
        if (dataDeNascimentoDoCliente < new DateTime(1900, 1, 1))
        {
            Console.WriteLine("A data de nascimento do cliente deve ser maior ou igual a 01/01/1900.");
            return;
        }

        // Endereço do cliente
        enderecoDoCliente = ObterEntradaNaoVazia("Digite o endereço do cliente:");

        // Telefone do cliente
        telefoneDoCliente = ObterEntradaNaoVazia("Digite o telefone do cliente:");

        // Exibição dos dados do cliente
        Console.WriteLine("Dados do Cliente:");
        Console.WriteLine($"Nome: {nomeDoCliente}");
        Console.WriteLine($"Sobrenome: {sobrenomeDoCliente}");
        Console.WriteLine($"CPF: {cpfDoCliente}");
        Console.WriteLine($"Sexo: {sexoDoCliente}");
        Console.WriteLine($"Data de Nascimento: {dataDeNascimentoDoCliente:dd/MM/yyyy}");
        Console.WriteLine($"Endereço: {enderecoDoCliente}");
        Console.WriteLine($"Telefone: {telefoneDoCliente}");
        Console.Write("Pressione qualquer tecla:");
        Console.ReadLine();
    }
}
